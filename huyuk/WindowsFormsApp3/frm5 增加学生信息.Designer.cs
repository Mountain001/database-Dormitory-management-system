namespace WindowsFormsApp3
{
    partial class frm5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm5));
            this.btn1 = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.cbx6 = new System.Windows.Forms.ComboBox();
            this.cbx5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(153, 359);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "添加";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(50, 19);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(113, 12);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "请认真填写以下信息";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(52, 40);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(29, 12);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "学号";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(52, 70);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(29, 12);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "姓名";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(52, 101);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(29, 12);
            this.lab4.TabIndex = 4;
            this.lab4.Text = "性别";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(50, 133);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(53, 12);
            this.lab5.TabIndex = 5;
            this.lab5.Text = "出生时间";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(50, 162);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(29, 12);
            this.lab6.TabIndex = 6;
            this.lab6.Text = "学院";
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(52, 195);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(29, 12);
            this.lab7.TabIndex = 7;
            this.lab7.Text = "电话";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(153, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 21);
            this.txt2.TabIndex = 8;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(153, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 21);
            this.txt1.TabIndex = 9;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(153, 133);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(122, 21);
            this.dtp1.TabIndex = 12;
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(153, 162);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(121, 20);
            this.cbx1.TabIndex = 13;
            // 
            // cbx2
            // 
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx2.Location = new System.Drawing.Point(153, 224);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(121, 20);
            this.cbx2.TabIndex = 16;
            this.cbx2.SelectedIndexChanged += new System.EventHandler(this.cbx2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "宿舍楼号";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(153, 192);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(121, 21);
            this.txt3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "宿舍号";
            // 
            // cbx4
            // 
            this.cbx4.FormattingEnabled = true;
            this.cbx4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbx4.Location = new System.Drawing.Point(153, 282);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(121, 20);
            this.cbx4.TabIndex = 23;
            this.cbx4.SelectedIndexChanged += new System.EventHandler(this.cbx4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "床位号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "是否缴费";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(153, 251);
            this.txt4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(122, 21);
            this.txt4.TabIndex = 27;
            // 
            // cbx6
            // 
            this.cbx6.FormattingEnabled = true;
            this.cbx6.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbx6.Location = new System.Drawing.Point(153, 101);
            this.cbx6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx6.Name = "cbx6";
            this.cbx6.Size = new System.Drawing.Size(121, 20);
            this.cbx6.TabIndex = 28;
            // 
            // cbx5
            // 
            this.cbx5.FormattingEnabled = true;
            this.cbx5.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cbx5.Location = new System.Drawing.Point(153, 311);
            this.cbx5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(121, 20);
            this.cbx5.TabIndex = 29;
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 430);
            this.Controls.Add(this.cbx5);
            this.Controls.Add(this.cbx6);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm5";
            this.Text = "增加学生信息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.ComboBox cbx6;
        private System.Windows.Forms.ComboBox cbx5;
    }
}