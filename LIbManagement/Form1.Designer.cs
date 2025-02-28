namespace LIbManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 154);
            button1.Name = "button1";
            button1.Size = new Size(154, 83);
            button1.TabIndex = 0;
            button1.Text = "اعضا";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(140, 58);
            button2.Name = "button2";
            button2.Size = new Size(154, 83);
            button2.TabIndex = 1;
            button2.Text = "کتاب ها";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(300, 58);
            button3.Name = "button3";
            button3.Size = new Size(154, 83);
            button3.TabIndex = 2;
            button3.Text = "تاریخچه";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(460, 58);
            button4.Name = "button4";
            button4.Size = new Size(153, 179);
            button4.TabIndex = 3;
            button4.Text = "امانات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveCaption;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(300, 154);
            button5.Name = "button5";
            button5.Size = new Size(154, 83);
            button5.TabIndex = 4;
            button5.Text = "امتیازات";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 39);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 5;
            label1.Text = "اتوماسیون کتاب گستر ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 431);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 6;
            label2.Text = "Amirhosein-2024";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 431);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "CopyRight ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(76, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 301);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "قابلیت ها";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(912, 460);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "اتوماسیون کتاب گستر ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
    }
}
