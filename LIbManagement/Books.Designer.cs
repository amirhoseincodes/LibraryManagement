namespace LIbManagement
{
    partial class Books
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
            name = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            excelExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, author, genre, date, bookId });
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "اسم کتاب";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // author
            // 
            author.DataPropertyName = "author";
            author.HeaderText = "اسم نویسنده";
            author.MinimumWidth = 6;
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // genre
            // 
            genre.DataPropertyName = "genre";
            genre.HeaderText = "ژانر";
            genre.MinimumWidth = 6;
            genre.Name = "genre";
            genre.ReadOnly = true;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "تاریخ انتشار";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // bookId
            // 
            bookId.DataPropertyName = "bookId";
            bookId.HeaderText = "شماره کتاب";
            bookId.MinimumWidth = 6;
            bookId.Name = "bookId";
            bookId.ReadOnly = true;
            // 
            // button3
            // 
            button3.Location = new Point(336, 22);
            button3.Name = "button3";
            button3.Size = new Size(72, 67);
            button3.TabIndex = 5;
            button3.Text = "حذف";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(120, 22);
            button2.Name = "button2";
            button2.Size = new Size(105, 67);
            button2.TabIndex = 6;
            button2.Text = "افزودن کتاب";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(102, 67);
            button1.TabIndex = 7;
            button1.Text = "به روز رسانی";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(231, 22);
            button4.Name = "button4";
            button4.Size = new Size(99, 67);
            button4.TabIndex = 8;
            button4.Text = "ویرایش کتاب";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(534, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(254, 61);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // excelExport
            // 
            excelExport.Location = new Point(414, 22);
            excelExport.Name = "excelExport";
            excelExport.Size = new Size(115, 67);
            excelExport.TabIndex = 10;
            excelExport.Text = "خروجی اکسل";
            excelExport.UseVisualStyleBackColor = true;
            excelExport.Click += excelExport_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(excelExport);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Books";
            RightToLeftLayout = true;
            Text = "کتاب ها";
            Load += Books_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn bookId;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button excelExport;
    }
}