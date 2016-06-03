namespace expert_system
{
    partial class form_create_scheme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_create_scheme = new System.Windows.Forms.DataGridView();
            this.btn_save_scheme = new System.Windows.Forms.Button();
            this.sfd_save_scheme = new System.Windows.Forms.SaveFileDialog();
            this.btn_open_existing = new System.Windows.Forms.Button();
            this.ofd_open_existing = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_create_scheme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_create_scheme
            // 
            this.dgv_create_scheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_create_scheme.Location = new System.Drawing.Point(12, 12);
            this.dgv_create_scheme.Name = "dgv_create_scheme";
            this.dgv_create_scheme.Size = new System.Drawing.Size(551, 455);
            this.dgv_create_scheme.TabIndex = 0;
            // 
            // btn_save_scheme
            // 
            this.btn_save_scheme.Location = new System.Drawing.Point(379, 473);
            this.btn_save_scheme.Name = "btn_save_scheme";
            this.btn_save_scheme.Size = new System.Drawing.Size(184, 23);
            this.btn_save_scheme.TabIndex = 1;
            this.btn_save_scheme.Text = "Сохранить схему";
            this.btn_save_scheme.UseVisualStyleBackColor = true;
            this.btn_save_scheme.Click += new System.EventHandler(this.btn_save_scheme_Click);
            // 
            // sfd_save_scheme
            // 
            this.sfd_save_scheme.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_save_scheme_FileOk);
            // 
            // btn_open_existing
            // 
            this.btn_open_existing.Location = new System.Drawing.Point(12, 473);
            this.btn_open_existing.Name = "btn_open_existing";
            this.btn_open_existing.Size = new System.Drawing.Size(361, 23);
            this.btn_open_existing.TabIndex = 3;
            this.btn_open_existing.Text = "Открыть существующую схему";
            this.btn_open_existing.UseVisualStyleBackColor = true;
            this.btn_open_existing.Click += new System.EventHandler(this.btn_open_existing_Click);
            // 
            // ofd_open_existing
            // 
            this.ofd_open_existing.FileName = "openFileDialog1";
            this.ofd_open_existing.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_open_existing_FileOk);
            // 
            // form_create_scheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 505);
            this.Controls.Add(this.btn_open_existing);
            this.Controls.Add(this.btn_save_scheme);
            this.Controls.Add(this.dgv_create_scheme);
            this.Name = "form_create_scheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новую схему";
            this.Load += new System.EventHandler(this.form_create_scheme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_create_scheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_create_scheme;
        private System.Windows.Forms.Button btn_save_scheme;
        private System.Windows.Forms.SaveFileDialog sfd_save_scheme;
        private System.Windows.Forms.Button btn_open_existing;
        private System.Windows.Forms.OpenFileDialog ofd_open_existing;
    }
}