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

            DataGridViewColumn Column_1 = new DataGridViewColumn();
            DataGridViewColumn Column_2 = new DataGridViewColumn();
            DataGridViewColumn Column_3 = new DataGridViewColumn();
            DataGridViewCheckBoxColumn Column_4 = new DataGridViewCheckBoxColumn();

            Column_1.HeaderText = "Имя";
            Column_2.HeaderText = "Правило";
            Column_3.HeaderText = "Вес";
            Column_4.HeaderText = "Обратимость";
            Column_1.CellTemplate = Cell_1;
            Column_2.CellTemplate = Cell_2;
            Column_3.CellTemplate = Cell_3;

            dgv_left.ReadOnly = true;
            dgv_left.AllowUserToAddRows = true;
            dgv_left.AllowUserToDeleteRows = true;
            dgv_left.Columns.Add(Column_1);
            dgv_left.Columns.Add(Column_2);
            dgv_left.Columns.Add(Column_3);
            dgv_left.Columns.Add(Column_4);
        }



        public static void right_data_grid(DataGridView dgv_right)
        {
            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell();

            DataGridViewColumn Column_1 = new DataGridViewColumn();
            DataGridViewColumn Column_2 = new DataGridViewColumn();

            Column_1.HeaderText = "Правило";
            Column_2.HeaderText = "Значение";
            Column_1.ReadOnly = true;
            Column_2.ReadOnly = false;
            Column_1.CellTemplate = Cell_1;
            Column_2.CellTemplate = Cell_2;

            dgv_right.AllowUserToAddRows = true;
            dgv_right.AllowUserToDeleteRows = true;
            dgv_right.Columns.Add(Column_1);
            dgv_right.Columns.Add(Column_2);
        }
    }
}
