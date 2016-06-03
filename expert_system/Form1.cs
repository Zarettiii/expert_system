﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using expert_system.Classes;

namespace expert_system
{
    public partial class Form1 : Form
    {
        c__expert_system es__hypothesis; // Гипотеза



        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            c__data_grids.left_data_grid(dgv_left);   // Настроить левый дата грид
            c__data_grids.right_data_grid(dgv_right); // Настроить правый дата грид
        }        



        /**
         * Заполнить таблицы данными из выбранной схемы
         */
        private void write_grids()
        {
            foreach (c__intermidiate_node in__item in es__hypothesis.l__intermidiate_node)
            {
                dgv_left.Rows.Add(
                                    "C" + in__item.get_index().ToString(),
                                    in__item.get_description(),
                                    in__item.get_weight().ToString(),
                                    in__item.get_reversibility()
                                 );
            }


            foreach (c__terminal_node tn__item in es__hypothesis.l__terminal_node)
            {
                dgv_left.Rows.Add(
                                    "E" + tn__item.get_index().ToString(),
                                    tn__item.get_description(),
                                    tn__item.get_weight().ToString(),
                                    false
                                 );

                dgv_right.Rows.Add(tn__item.get_description(), "1");
            }
        }



        /**
         * Рассчитать ответ
         */
        private void btn_calculate_Click(object sender, EventArgs e)
        {                    
            for (int i__1 = 0; i__1 < es__hypothesis.l__terminal_node.Count(); i__1++)
            {
                try
                {
                    es__hypothesis.l__terminal_node[i__1].set_value(int.Parse(dgv_right.Rows[i__1].Cells[1].Value.ToString()));
                }
                catch (Exception)
                {
                    MessageBox.Show("Заполните поля корректно");
                }                
            }

            foreach (c__intermidiate_node in__item in es__hypothesis.l__intermidiate_node)
            {
                in__item.calculate_logical_value();
            }

            txt_result.Text = es__hypothesis.calculate().ToString(); // Вывести результат на форму
        }



        /**
         * Кнопка открытия окна выбора файла
         */
        private void btn_select_scheme_Click(object sender, EventArgs e)
        {
            ofd_select_scheme.FileName = @"*.esd"; // Укакзать начальное имя файла для окна выбора

            //
            // Указать директорию, которая будет открыта в окне
            //
            ofd_select_scheme.InitialDirectory = Application.ExecutablePath; 


            ofd_select_scheme.ShowDialog(); // Показать окно выбора файла
        }



        /**
         * При выборе файла в окне выбора файла
         */
        private void ofd_select_scheme_FileOk(object sender, CancelEventArgs e)
        {            
            try
            {
                //
                // Очистить таблицы
                //
                dgv_left.Rows.Clear();
                dgv_right.Rows.Clear();


                //
                // Развернуть экспертную систему
                //
                es__hypothesis = new c__expert_system(ofd_select_scheme.FileName);


                write_grids(); //  Заполнить таблицы
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }



        /**
         * Кнопка создания новой схемы
         */
        private void btn_create_scheme_Click(object sender, EventArgs e)
        {
            form_create_scheme form__create_scheme = new form_create_scheme(); // Создать экземпляр формы

            form__create_scheme.Show(); // Показать форму
        }
    }
}
