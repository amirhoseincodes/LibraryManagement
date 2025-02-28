namespace LIbManagement
{
    partial class AddOrEditBook
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
            label4 = new Label();
            button1 = new Button();
            textName = new TextBox();
            textAuthor = new TextBox();
            textGenre = new TextBox();
            textDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "نام کتاب :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "نویسنده :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 123);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "ژانر : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 165);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "تاریخ انتشار :";
            // 
            // button1
            // 
            button1.Location = new Point(49, 209);
            button1.Name = "button1";
            button1.Size = new Size(96, 43);
            button1.TabIndex = 4;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textName
            // 
            textName.Location = new Point(38, 32);
            textName.Name = "textName";
            textName.Size = new Size(136, 27);
            textName.TabIndex = 5;
            textName.TextChanged += textName_TextChanged;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(37, 75);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(139, 27);
            textAuthor.TabIndex = 6;
            // 
            // textGenre
            // 
            textGenre.Location = new Point(43, 120);
            textGenre.Name = "textGenre";
            textGenre.Size = new Size(134, 27);
            textGenre.TabIndex = 7;
            // 
            // textDate
            // 
            textDate.Location = new Point(43, 165);
            textDate.Name = "textDate";
            textDate.Size = new Size(134, 27);
            textDate.TabIndex = 8;
            // 
            // AddOrEditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(281, 264);
            Controls.Add(textDate);
            Controls.Add(textGenre);
            Controls.Add(textAuthor);
            Controls.Add(textName);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOrEditBook";
            RightToLeft = RightToLeft.Yes;
            Text = "AddOrEditBook";
            Load += AddOrEditBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textName;
        private TextBox textAuthor;
        private TextBox textGenre;
        private TextBox textDate;
    }
}