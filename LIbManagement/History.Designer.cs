namespace LIbManagement
{
    partial class History
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
            dataGridView1 = new DataGridView();
            relatedUser = new DataGridViewTextBoxColumn();
            actionType = new DataGridViewTextBoxColumn();
            relatedBook = new DataGridViewTextBoxColumn();
            actionDate = new DataGridViewTextBoxColumn();
            excelExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkKhaki;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { relatedUser, actionType, relatedBook, actionDate });
            dataGridView1.Location = new Point(8, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 378);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // relatedUser
            // 
            relatedUser.DataPropertyName = "relatedUser";
            relatedUser.HeaderText = "کاربر اقدام کننده";
            relatedUser.MinimumWidth = 6;
            relatedUser.Name = "relatedUser";
            // 
            // actionType
            // 
            actionType.DataPropertyName = "actionType";
            actionType.HeaderText = "شرح اقدام";
            actionType.MinimumWidth = 6;
            actionType.Name = "actionType";
            // 
            // relatedBook
            // 
            relatedBook.DataPropertyName = "relatedBook";
            relatedBook.HeaderText = "کتاب (در صورت لزوم)";
            relatedBook.MinimumWidth = 6;
            relatedBook.Name = "relatedBook";
            // 
            // actionDate
            // 
            actionDate.DataPropertyName = "actionDate";
            actionDate.HeaderText = "تاریخ و زمان اقدام";
            actionDate.MinimumWidth = 6;
            actionDate.Name = "actionDate";
            // 
            // excelExport
            // 
            excelExport.Location = new Point(12, 1);
            excelExport.Name = "excelExport";
            excelExport.Size = new Size(107, 55);
            excelExport.TabIndex = 1;
            excelExport.Text = "خروجی اکسل";
            excelExport.UseVisualStyleBackColor = true;
            excelExport.Click += excelExport_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(excelExport);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "History";
            RightToLeft = RightToLeft.Yes;
            Text = "تاریخچه";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn relatedUser;
        private DataGridViewTextBoxColumn actionType;
        private DataGridViewTextBoxColumn relatedBook;
        private DataGridViewTextBoxColumn actionDate;
        private Button excelExport;
    }
}