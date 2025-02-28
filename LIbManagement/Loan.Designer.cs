namespace LIbManagement
{
    partial class Loan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            family = new DataGridViewTextBoxColumn();
            memberId = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            point = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            bookname = new DataGridViewTextBoxColumn();
            authorname = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            bookcode = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBookName = new TextBox();
            textName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(573, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 41);
            label1.TabIndex = 0;
            label1.Text = "فرم امانت کتابها";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 59);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 1;
            label2.Text = "شخص مد نظر را انتخاب کنید";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 59);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 2;
            label3.Text = "کتاب مد نظر را انتخاب کنید";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, family, memberId, type, point });
            dataGridView1.Location = new Point(446, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(342, 223);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "نام";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // family
            // 
            family.DataPropertyName = "family";
            family.HeaderText = "نام خانوادگی";
            family.MinimumWidth = 6;
            family.Name = "family";
            // 
            // memberId
            // 
            memberId.DataPropertyName = "memberId";
            memberId.HeaderText = "کد شخص";
            memberId.MinimumWidth = 6;
            memberId.Name = "memberId";
            memberId.Visible = false;
            // 
            // type
            // 
            type.DataPropertyName = "memberType";
            type.HeaderText = "وضعیت شخص";
            type.MinimumWidth = 6;
            type.Name = "type";
            // 
            // point
            // 
            point.DataPropertyName = "point";
            point.HeaderText = "امتیاز";
            point.MinimumWidth = 6;
            point.Name = "point";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { bookname, authorname, bookId, bookcode });
            dataGridView2.Location = new Point(11, 151);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(429, 223);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // bookname
            // 
            bookname.DataPropertyName = "name";
            bookname.HeaderText = "نام کتاب";
            bookname.MinimumWidth = 6;
            bookname.Name = "bookname";
            bookname.Width = 125;
            // 
            // authorname
            // 
            authorname.DataPropertyName = "author";
            authorname.HeaderText = "نام نویسنده";
            authorname.MinimumWidth = 6;
            authorname.Name = "authorname";
            authorname.Width = 125;
            // 
            // bookId
            // 
            bookId.DataPropertyName = "available";
            bookId.HeaderText = "وضعیت کتاب";
            bookId.MinimumWidth = 6;
            bookId.Name = "bookId";
            bookId.Width = 125;
            // 
            // bookcode
            // 
            bookcode.DataPropertyName = "bookId";
            bookcode.HeaderText = "کد کتاب";
            bookcode.MinimumWidth = 6;
            bookcode.Name = "bookcode";
            bookcode.Visible = false;
            bookcode.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(461, 389);
            button1.Name = "button1";
            button1.Size = new Size(163, 49);
            button1.TabIndex = 5;
            button1.Text = "امانت گرفتن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 389);
            button2.Name = "button2";
            button2.Size = new Size(163, 49);
            button2.TabIndex = 6;
            button2.Text = "برگرداندن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBookName);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 56);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // textBookName
            // 
            textBookName.Location = new Point(123, 26);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(197, 27);
            textBookName.TabIndex = 3;
            textBookName.TextChanged += textBookName_TextChanged;
            // 
            // textName
            // 
            textName.Location = new Point(431, 26);
            textName.Name = "textName";
            textName.Size = new Size(197, 27);
            textName.TabIndex = 2;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 33);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "نام شخص :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 33);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "نام کتاب :";
            // 
            // Loan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Loan";
            RightToLeft = RightToLeft.Yes;
            Text = "Loan";
            Load += Loan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn authorname;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn bookcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn family;
        private DataGridViewTextBoxColumn memberId;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn point;
        private GroupBox groupBox1;
        private TextBox textBookName;
        private TextBox textName;
        private Label label5;
        private Label label4;
    }
}