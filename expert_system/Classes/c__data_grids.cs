using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expert_system.Classes
{
    static class c__data_grids
    {
        public static void left_data_grid(DataGridView dgv_left)
        {
            dgv_left.AutoGenerateColumns = true;

            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_4 = new DataGridViewTextBoxCell();

            DataGridViewColumn col__name = new DataGridViewColumn();
            DataGridViewColumn col__rule = new DataGridViewColumn();
            DataGridViewColumn col__weigth = new DataGridViewColumn();

            DataGridViewCheckBoxColumn col__reversability = new DataGridViewCheckBoxColumn();

            col__name.HeaderText          = "Имя";
            col__rule.HeaderText          = "Правило";
            col__weigth.HeaderText        = "Вес";
            col__reversability.HeaderText = "Обратимость";

            col__name.Width = 40;
            col__rule.Width = 330;
            col__weigth.Width = 40;
            col__reversability.Width = 80;


            col__name.CellTemplate = Cell_1;
            col__rule.CellTemplate = Cell_2;
            col__weigth.CellTemplate = Cell_3;

            dgv_left.ReadOnly = true;
            dgv_left.AllowUserToAddRows = false;
            dgv_left.AllowUserToDeleteRows = false;
            dgv_left.Columns.Add(col__name);
            dgv_left.Columns.Add(col__rule);
            dgv_left.Columns.Add(col__weigth);
            dgv_left.Columns.Add(col__reversability);
        }



        public static void right_data_grid(DataGridView dgv_right)
        {
            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();

            DataGridViewColumn col__rule = new DataGridViewColumn();
            DataGridViewColumn col__value = new DataGridViewColumn();

            col__rule.HeaderText = "Правило";
            col__value.HeaderText = "Значение";

            col__rule.Width = 300;
            col__value.Width = 65;

            col__rule.ReadOnly = true;
            col__value.ReadOnly = false;


            col__rule.CellTemplate = Cell_1;
            col__value.CellTemplate = Cell_2;

            dgv_right.AllowUserToAddRows = false;
            dgv_right.AllowUserToDeleteRows = false;
            dgv_right.Columns.Add(col__rule);
            dgv_right.Columns.Add(col__value);
        }



        public static void create_scheme_data_grid(DataGridView dgv_create_scheme)
        {
            dgv_create_scheme.AutoGenerateColumns = true;

            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_4 = new DataGridViewTextBoxCell();

            DataGridViewColumn col__name = new DataGridViewColumn();
            DataGridViewColumn col__rule = new DataGridViewColumn();
            DataGridViewColumn col__weigth = new DataGridViewColumn();
            DataGridViewColumn col__parent = new DataGridViewColumn();

            DataGridViewCheckBoxColumn col__reversability = new DataGridViewCheckBoxColumn();

            col__name.HeaderText = "Имя";
            col__rule.HeaderText = "Правило";
            col__weigth.HeaderText = "Вес";
            col__parent.HeaderText = "Родитель";
            col__reversability.HeaderText = "Обратимость";

            col__name.Width = 40;
            col__rule.Width = 280;        
            col__weigth.Width = 40;
            col__parent.Width = 60;
            col__reversability.Width = 80;


            col__name.CellTemplate = Cell_1;
            col__rule.CellTemplate = Cell_2;
            col__weigth.CellTemplate = Cell_3;
            col__parent.CellTemplate = Cell_4;

            dgv_create_scheme.ReadOnly = false;
            dgv_create_scheme.AllowUserToAddRows = true;
            dgv_create_scheme.AllowUserToDeleteRows = true;

            dgv_create_scheme.Columns.Add(col__name);
            dgv_create_scheme.Columns.Add(col__rule);
            dgv_create_scheme.Columns.Add(col__weigth);
            dgv_create_scheme.Columns.Add(col__parent);
            dgv_create_scheme.Columns.Add(col__reversability);
        }
    }
}
