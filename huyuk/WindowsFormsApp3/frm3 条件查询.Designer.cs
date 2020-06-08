namespace WindowsFormsApp3
{
    partial class frm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lvw1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lvw1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学院";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(162, 48);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(121, 21);
            this.txt1.TabIndex = 3;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(162, 6);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(121, 20);
            this.cbx1.TabIndex = 6;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(162, 103);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "查询";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "两个里面至少一个";
            // 
            // lvw1
            // 
            this.lvw1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvw1.Location = new System.Drawing.Point(9, 171);
            this.lvw1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvw1.Name = "lvw1";
            this.lvw1.RowTemplate.Height = 27;
            this.lvw1.Size = new System.Drawing.Size(673, 182);
            this.lvw1.TabIndex = 10;
            this.lvw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 363);
            this.Controls.Add(this.lvw1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm3";
            this.Text = "范围查询";
            this.Load += new System.EventHandler(this.frm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView lvw1;
    }
}