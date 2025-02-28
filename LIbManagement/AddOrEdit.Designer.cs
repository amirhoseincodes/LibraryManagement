namespace LIbManagement
{
    partial class AddOrEdit
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
            textName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textFamily = new TextBox();
            textType = new TextBox();
            label4 = new Label();
            textPoint = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)textPoint).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 12);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // textName
            // 
            textName.Location = new Point(45, 12);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 57);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 99);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 3;
            label3.Text = "نوع عضویت:";
            // 
            // textFamily
            // 
            textFamily.Location = new Point(45, 54);
            textFamily.Name = "textFamily";
            textFamily.Size = new Size(122, 27);
            textFamily.TabIndex = 4;
            // 
            // textType
            // 
            textType.Location = new Point(45, 92);
            textType.Name = "textType";
            textType.Size = new Size(125, 27);
            textType.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 134);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "امتیاز:";
            // 
            // textPoint
            // 
            textPoint.Location = new Point(45, 134);
            textPoint.Name = "textPoint";
            textPoint.Size = new Size(125, 27);
            textPoint.TabIndex = 7;
            textPoint.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(48, 179);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 8;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddOrEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(280, 229);
            Controls.Add(button1);
            Controls.Add(textPoint);
            Controls.Add(label4);
            Controls.Add(textType);
            Controls.Add(textFamily);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOrEdit";
            RightToLeft = RightToLeft.Yes;
            Text = "افزودن و ویرایش عضو";
            Load += AddOrEdit_Load;
            ((System.ComponentModel.ISupportInitialize)textPoint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label label2;
        private Label label3;
        private TextBox textFamily;
        private TextBox textType;
        private Label label4;
        private NumericUpDown textPoint;
        private Button button1;
    }
}