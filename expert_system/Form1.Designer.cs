using System;

namespace expert_system
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dgv_left = new System.Windows.Forms.DataGridView();
            this.dgv_right = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_select_scheme = new System.Windows.Forms.Button();
            this.ofd_select_scheme = new System.Windows.Forms.OpenFileDialog();
            this.btn_create_scheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(881, 14);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 3;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(819, 41);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(162, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Рассчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dgv_left
            // 
            this.dgv_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_left.Location = new System.Drawing.Point(15, 89);
            this.dgv_left.Name = "dgv_left";
            this.dgv_left.Size = new System.Drawing.Size(551, 455);
            this.dgv_left.TabIndex = 5;
            // 
            // dgv_right
            // 
            this.dgv_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_right.Location = new System.Drawing.Point(572, 89);
            this.dgv_right.Name = "dgv_right";
            this.dgv_right.Size = new System.Drawing.Size(412, 455);
            this.dgv_right.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите данные:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Схема экспертной системы:";
            // 
            // btn_select_scheme
            // 
            this.btn_select_scheme.Location = new System.Drawing.Point(12, 12);
            this.btn_select_scheme.Name = "btn_select_scheme";
            this.btn_select_scheme.Size = new System.Drawing.Size(139, 23);
            this.btn_select_scheme.TabIndex = 9;
            this.btn_select_scheme.Text = "Выбрать схему";
            this.btn_select_scheme.UseVisualStyleBackColor = true;
            this.btn_select_scheme.Click += new System.EventHandler(this.btn_select_scheme_Click);
            // 
            // ofd_select_scheme
            // 
            this.ofd_select_scheme.FileName = "*.esd";
            this.ofd_select_scheme.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\IDE";
            this.ofd_select_scheme.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_select_scheme_FileOk);
            // 
            // btn_create_scheme
            // 
            this.btn_create_scheme.Location = new System.Drawing.Point(12, 41);
            this.btn_create_scheme.Name = "btn_create_scheme";
            this.btn_create_scheme.Size = new System.Drawing.Size(139, 23);
            this.btn_create_scheme.TabIndex = 10;
            this.btn_create_scheme.Text = "Создать схему";
            this.btn_create_scheme.UseVisualStyleBackColor = true;
            this.btn_create_scheme.Click += new System.EventHandler(this.btn_create_scheme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 556);
            this.Controls.Add(this.btn_create_scheme);
            this.Controls.Add(this.btn_select_scheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_right);
            this.Controls.Add(this.dgv_left);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспертная система";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dgv_left;
        private System.Windows.Forms.DataGridView dgv_right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_select_scheme;
        private System.Windows.Forms.OpenFileDialog ofd_select_scheme;
        private System.Windows.Forms.Button btn_create_scheme;
    }
}

