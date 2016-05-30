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
            this.btn_hypothesis_1 = new System.Windows.Forms.Button();
            this.btn_hypothesis_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dgv_left = new System.Windows.Forms.DataGridView();
            this.dgv_right = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hypothesis_1
            // 
            this.btn_hypothesis_1.Location = new System.Drawing.Point(12, 12);
            this.btn_hypothesis_1.Name = "btn_hypothesis_1";
            this.btn_hypothesis_1.Size = new System.Drawing.Size(129, 23);
            this.btn_hypothesis_1.TabIndex = 0;
            this.btn_hypothesis_1.Text = "Гипотеза 1";
            this.btn_hypothesis_1.UseVisualStyleBackColor = true;
            this.btn_hypothesis_1.Click += new System.EventHandler(this.btn_hypothesis_1_Click);
            // 
            // btn_hypothesis_2
            // 
            this.btn_hypothesis_2.Location = new System.Drawing.Point(12, 41);
            this.btn_hypothesis_2.Name = "btn_hypothesis_2";
            this.btn_hypothesis_2.Size = new System.Drawing.Size(129, 23);
            this.btn_hypothesis_2.TabIndex = 1;
            this.btn_hypothesis_2.Text = "Гипотеза 2";
            this.btn_hypothesis_2.UseVisualStyleBackColor = true;
            this.btn_hypothesis_2.Click += new System.EventHandler(this.btn_hypothesis_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(670, 14);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 3;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(608, 41);
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
            this.dgv_left.Location = new System.Drawing.Point(12, 71);
            this.dgv_left.Name = "dgv_left";
            this.dgv_left.Size = new System.Drawing.Size(384, 384);
            this.dgv_left.TabIndex = 5;
            // 
            // dgv_right
            // 
            this.dgv_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_right.Location = new System.Drawing.Point(402, 71);
            this.dgv_right.Name = "dgv_right";
            this.dgv_right.Size = new System.Drawing.Size(368, 384);
            this.dgv_right.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.dgv_right);
            this.Controls.Add(this.dgv_left);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hypothesis_2);
            this.Controls.Add(this.btn_hypothesis_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hypothesis_1;
        private System.Windows.Forms.Button btn_hypothesis_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dgv_left;
        private System.Windows.Forms.DataGridView dgv_right;
    }
}

