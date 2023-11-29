namespace WindowsFormsApp1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.conn = new System.Data.OleDb.OleDbConnection();
            this.btnReterieve = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.MaskedTextBox();
            this.tbxFirstName = new System.Windows.Forms.MaskedTextBox();
            this.tbxAddress = new System.Windows.Forms.MaskedTextBox();
            this.tbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conn
            // 
            this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\mySpace\\fop\\WIUT.mdb";
            // 
            // btnReterieve
            // 
            this.btnReterieve.Location = new System.Drawing.Point(66, 275);
            this.btnReterieve.Name = "btnReterieve";
            this.btnReterieve.Size = new System.Drawing.Size(75, 23);
            this.btnReterieve.TabIndex = 0;
            this.btnReterieve.Text = "Reterieve";
            this.btnReterieve.UseVisualStyleBackColor = true;
            this.btnReterieve.Click += new System.EventHandler(this.btnReterieve_Click);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(80, 96);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 22);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(255, 96);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbxFirstName.TabIndex = 2;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(432, 96);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 22);
            this.tbxAddress.TabIndex = 3;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(579, 96);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(100, 22);
            this.tbxPhone.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(308, 275);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.btnReterieve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Data.OleDb.OleDbConnection conn;
        private System.Windows.Forms.Button btnReterieve;
        private System.Windows.Forms.MaskedTextBox tbxLastName;
        private System.Windows.Forms.MaskedTextBox tbxFirstName;
        private System.Windows.Forms.MaskedTextBox tbxAddress;
        private System.Windows.Forms.MaskedTextBox tbxPhone;
        private System.Windows.Forms.Button btnInsert;
    }
}

