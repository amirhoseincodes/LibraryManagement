namespace LIbManagement
{
    partial class Members
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
            NameColumn = new DataGridViewTextBoxColumn();
            FamilyColumn = new DataGridViewTextBoxColumn();
            MemberNumberColumn = new DataGridViewTextBoxColumn();
            MemberTypeColumn = new DataGridViewTextBoxColumn();
            MemberPointColumn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            excelExport = new Button();
            excelImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PaleGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, FamilyColumn, MemberNumberColumn, MemberTypeColumn, MemberPointColumn });
            dataGridView1.Location = new Point(82, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 353);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "name";
            NameColumn.HeaderText = "نام";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // FamilyColumn
            // 
            FamilyColumn.DataPropertyName = "family";
            FamilyColumn.HeaderText = "نام خانوادگی";
            FamilyColumn.MinimumWidth = 6;
            FamilyColumn.Name = "FamilyColumn";
            FamilyColumn.ReadOnly = true;
            // 
            // MemberNumberColumn
            // 
            MemberNumberColumn.DataPropertyName = "memberId";
            MemberNumberColumn.HeaderText = "شماره عضویت";
            MemberNumberColumn.MinimumWidth = 6;
            MemberNumberColumn.Name = "MemberNumberColumn";
            MemberNumberColumn.ReadOnly = true;
            // 
            // MemberTypeColumn
            // 
            MemberTypeColumn.DataPropertyName = "memberType";
            MemberTypeColumn.HeaderText = "نوع عضویت";
            MemberTypeColumn.MinimumWidth = 6;
            MemberTypeColumn.Name = "MemberTypeColumn";
            MemberTypeColumn.ReadOnly = true;
            // 
            // MemberPointColumn
            // 
            MemberPointColumn.DataPropertyName = "point";
            MemberPointColumn.HeaderText = "امتیاز";
            MemberPointColumn.MinimumWidth = 6;
            MemberPointColumn.Name = "MemberPointColumn";
            MemberPointColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(454, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(325, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 67);
            button1.TabIndex = 2;
            button1.Text = "به روز رسانی";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 12);
            button2.Name = "button2";
            button2.Size = new Size(129, 67);
            button2.TabIndex = 3;
            button2.Text = "افزودن شخص";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 193);
            button3.Name = "button3";
            button3.Size = new Size(63, 113);
            button3.TabIndex = 4;
            button3.Text = "حذف";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(64, 67);
            button4.TabIndex = 5;
            button4.Text = "ویرایش";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // excelExport
            // 
            excelExport.Location = new Point(82, 12);
            excelExport.Name = "excelExport";
            excelExport.Size = new Size(102, 67);
            excelExport.TabIndex = 6;
            excelExport.Text = "خروجی اکسل";
            excelExport.UseVisualStyleBackColor = true;
            excelExport.Click += button5_Click;
            // 
            // excelImport
            // 
            excelImport.Location = new Point(12, 85);
            excelImport.Name = "excelImport";
            excelImport.Size = new Size(64, 102);
            excelImport.TabIndex = 7;
            excelImport.Text = "ورودی اکسل";
            excelImport.UseVisualStyleBackColor = true;
            excelImport.Click += excelImport_Click;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(excelImport);
            Controls.Add(excelExport);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Members";
            RightToLeft = RightToLeft.Yes;
            Text = "اعضا";
            Load += Members_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn FamilyColumn;
        private DataGridViewTextBoxColumn MemberNumberColumn;
        private DataGridViewTextBoxColumn MemberTypeColumn;
        private DataGridViewTextBoxColumn MemberPointColumn;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button excelExport;
        private Button excelImport;
    }
}