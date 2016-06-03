using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using expert_system.Classes;

namespace expert_system
{
    public partial class form_create_scheme : Form
    {
        public form_create_scheme()
        {
            InitializeComponent();
        }

        private void form_create_scheme_Load(object sender, EventArgs e)
        {
            c__data_grids.create_scheme_data_grid(dgv_create_scheme); // Настроить дата грид
        }



        private void btn_save_scheme_Click(object sender, EventArgs e)
        {
            sfd_save_scheme.ShowDialog(); // Показать окно сохранения файла
        }



        /**
         * Запись введенных данных в файл
         * 
         * @param  string  s__faile_path  Путь файла
         */
        private void save_scheme(string s__faile_path)
        {
            string s__new_line; // Строка для записи в файл


            StreamWriter sw__file = new StreamWriter(s__faile_path); // Открыть файл для записи


            //
            // Произвести запись всех строк таблицы в файл
            //
            foreach (DataGridViewRow row__item in dgv_create_scheme.Rows)
            {
                //
                // Если строка таблицы пуста, то перейти к следующей итерации
                //
                if(row__item.Cells[0].Value == null)
                {
                    continue; // Перейти к следующей итерации
                }


                s__new_line = ""; // Очистить строку


                s__new_line += row__item.Cells[0].Value.ToString().Substring(0, 1);
                s__new_line += "/";
                s__new_line += row__item.Cells[0].Value.ToString().Substring(1);
                s__new_line += "/";
                s__new_line += row__item.Cells[1].Value.ToString();
                s__new_line += "/";

                if (row__item.Cells[3].Value != null)
                {
                    s__new_line += row__item.Cells[3].Value.ToString().Substring(1);
                }
                
                s__new_line += "/";
                s__new_line += row__item.Cells[2].Value.ToString();
                s__new_line += "/";

                if (row__item.Cells[4].Value.ToString() == "True")
                {
                    s__new_line += "1";
                }
                else
                {
                    s__new_line += "0";
                }

                sw__file.WriteLine(s__new_line);
            }


            sw__file.Close(); // Закрыть запись файла
        }



        private void sfd_save_scheme_FileOk(object sender, CancelEventArgs e)
        {
            save_scheme(sfd_save_scheme.FileName); // Сохранить схему
        }



        private void btn_open_existing_Click(object sender, EventArgs e)
        {
            ofd_open_existing.FileName = @"*.esd"; // Укакзать начальное имя файла для окна выбора

            //
            // Указать директорию, которая будет открыта в окне
            //
            ofd_open_existing.InitialDirectory = Application.ExecutablePath;


            ofd_open_existing.ShowDialog(); // Показать окно выбора файла         
        }



        private void ofd_open_existing_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string s__line; // Строка для чтения файла 


                StreamReader sr__file = new StreamReader(ofd_open_existing.FileName); // Открыть чтение файла


                //
                // Заполнить таблицу данными из файла
                //
                while ((s__line = sr__file.ReadLine()) != null)
                {                    
                    //
                    // Массив с данными из строки
                    // 
                    // [0] - "C" (промежуточный узел)   "Е" (терминальный узел)
                    // [1] - Индекс узла
                    // [2] - Описание узла
                    // [3] - Индекс промежуточного родительского узла
                    // [4] - Вес узла                
                    // [5] - Обратимость узла (1 - обратим, 0 - необратим)
                    //
                    string[] a__s__data = s__line.Split('/');


                    dgv_create_scheme.Rows.Add(
                                                a__s__data[0].ToString() + a__s__data[1].ToString(),
                                                a__s__data[2].ToString(),
                                                a__s__data[4].ToString(),
                                                "C" + a__s__data[3].ToString(),
                                                bool_converter(int.Parse(a__s__data[5].ToString()))
                                              );
                }


                sr__file.Close(); // Закрыть чтение файла
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message); // Показать уведомление об ошибке
            }
        }



        /**
         * Конвертирует 1 или 0  в bool
         * 
         * @param  int  i__num  Число для конвертации
         * 
         * @return  bool  Логическое значение  
         */
        private bool bool_converter(int i__num)
        {
            if (i__num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
