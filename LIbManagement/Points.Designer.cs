namespace LIbManagement
{
    partial class Points
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
            family = new DataGridViewTextBoxColumn();
            memberType = new DataGridViewTextBoxColumn();
            point = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            excelExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.OliveDrab;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, family, memberType, point });
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 345);
            dataGridView1.TabIndex = 0;
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
            // memberType
            // 
            memberType.DataPropertyName = "memberType";
            memberType.HeaderText = "وضعیت";
            memberType.MinimumWidth = 6;
            memberType.Name = "memberType";
            // 
            // point
            // 
            point.DataPropertyName = "point";
            point.HeaderText = "امتیاز";
            point.MinimumWidth = 6;
            point.Name = "point";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(471, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // excelExport
            // 
            excelExport.Location = new Point(12, 24);
            excelExport.Name = "excelExport";
            excelExport.Size = new Size(114, 63);
            excelExport.TabIndex = 2;
            excelExport.Text = "خروجی اکسل";
            excelExport.UseVisualStyleBackColor = true;
            excelExport.Click += excelExport_Click;
            // 
            // Points
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(excelExport);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Points";
            RightToLeft = RightToLeft.Yes;
            Text = "Points";
            Load += Points_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn family;
        private DataGridViewTextBoxColumn memberType;
        private DataGridViewTextBoxColumn point;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button excelExport;
    }
}