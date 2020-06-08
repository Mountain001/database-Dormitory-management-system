namespace WindowsFormsApp3
{
    partial class frm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试数据库连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.范围查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.精确查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出入登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看登记表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统操作ToolStripMenuItem,
            this.数据库操作ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.宿舍管理ToolStripMenuItem,
            this.出入登记ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统操作ToolStripMenuItem
            // 
            this.系统操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.关闭系统ToolStripMenuItem});
            this.系统操作ToolStripMenuItem.Name = "系统操作ToolStripMenuItem";
            this.系统操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统操作ToolStripMenuItem.Text = "系统操作";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 关闭系统ToolStripMenuItem
            // 
            this.关闭系统ToolStripMenuItem.Name = "关闭系统ToolStripMenuItem";
            this.关闭系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭系统ToolStripMenuItem.Text = "关闭系统";
            this.关闭系统ToolStripMenuItem.Click += new System.EventHandler(this.关闭系统ToolStripMenuItem_Click);
            // 
            // 数据库操作ToolStripMenuItem
            // 
            this.数据库操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试数据库连接ToolStripMenuItem,
            this.数据库登录ToolStripMenuItem});
            this.数据库操作ToolStripMenuItem.Name = "数据库操作ToolStripMenuItem";
            this.数据库操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据库操作ToolStripMenuItem.Text = "连接";
            // 
            // 测试数据库连接ToolStripMenuItem
            // 
            this.测试数据库连接ToolStripMenuItem.Name = "测试数据库连接ToolStripMenuItem";
            this.测试数据库连接ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.测试数据库连接ToolStripMenuItem.Text = "测试数据库连接";
            this.测试数据库连接ToolStripMenuItem.Click += new System.EventHandler(this.测试数据库连接ToolStripMenuItem_Click);
            // 
            // 数据库登录ToolStripMenuItem
            // 
            this.数据库登录ToolStripMenuItem.Name = "数据库登录ToolStripMenuItem";
            this.数据库登录ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.数据库登录ToolStripMenuItem.Text = "数据库登录";
            this.数据库登录ToolStripMenuItem.Click += new System.EventHandler(this.数据库登录ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.范围查询ToolStripMenuItem,
            this.精确查询ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 范围查询ToolStripMenuItem
            // 
            this.范围查询ToolStripMenuItem.Name = "范围查询ToolStripMenuItem";
            this.范围查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.范围查询ToolStripMenuItem.Text = "范围查询";
            this.范围查询ToolStripMenuItem.Click += new System.EventHandler(this.范围查询ToolStripMenuItem_Click);
            // 
            // 精确查询ToolStripMenuItem
            // 
            this.精确查询ToolStripMenuItem.Name = "精确查询ToolStripMenuItem";
            this.精确查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.精确查询ToolStripMenuItem.Text = "精确查询";
            this.精确查询ToolStripMenuItem.Click += new System.EventHandler(this.精确查询ToolStripMenuItem_Click);
            // 
            // 宿舍管理ToolStripMenuItem
            // 
            this.宿舍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.更改学生信息ToolStripMenuItem});
            this.宿舍管理ToolStripMenuItem.Name = "宿舍管理ToolStripMenuItem";
            this.宿舍管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宿舍管理ToolStripMenuItem.Text = "宿舍管理";
            // 
            // 增加学生信息ToolStripMenuItem
            // 
            this.增加学生信息ToolStripMenuItem.Name = "增加学生信息ToolStripMenuItem";
            this.增加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增加学生信息ToolStripMenuItem.Text = "增加学生信息";
            this.增加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.增加学生信息ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 更改学生信息ToolStripMenuItem
            // 
            this.更改学生信息ToolStripMenuItem.Name = "更改学生信息ToolStripMenuItem";
            this.更改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.更改学生信息ToolStripMenuItem.Text = "更改学生信息";
            this.更改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.更改学生信息ToolStripMenuItem_Click);
            // 
            // 出入登记ToolStripMenuItem
            // 
            this.出入登记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入登记ToolStripMenuItem,
            this.出登记ToolStripMenuItem,
            this.查看登记表ToolStripMenuItem});
            this.出入登记ToolStripMenuItem.Name = "出入登记ToolStripMenuItem";
            this.出入登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.出入登记ToolStripMenuItem.Text = "出入登记";
            // 
            // 入登记ToolStripMenuItem
            // 
            this.入登记ToolStripMenuItem.Name = "入登记ToolStripMenuItem";
            this.入登记ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.入登记ToolStripMenuItem.Text = "入登记";
            this.入登记ToolStripMenuItem.Click += new System.EventHandler(this.入登记ToolStripMenuItem_Click);
            // 
            // 出登记ToolStripMenuItem
            // 
            this.出登记ToolStripMenuItem.Name = "出登记ToolStripMenuItem";
            this.出登记ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.出登记ToolStripMenuItem.Text = "出登记";
            this.出登记ToolStripMenuItem.Click += new System.EventHandler(this.出登记ToolStripMenuItem_Click);
            // 
            // 查看登记表ToolStripMenuItem
            // 
            this.查看登记表ToolStripMenuItem.Name = "查看登记表ToolStripMenuItem";
            this.查看登记表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看登记表ToolStripMenuItem.Text = "查看登记表";
            this.查看登记表ToolStripMenuItem.Click += new System.EventHandler(this.查看登记表ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助文件ToolStripMenuItem
            // 
            this.查看帮助文件ToolStripMenuItem.Name = "查看帮助文件ToolStripMenuItem";
            this.查看帮助文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看帮助文件ToolStripMenuItem.Text = "查看帮助文件";
            this.查看帮助文件ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助文件ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "李东瑞";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "201614930104";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(249, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "侯奕安";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(218, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "201614930106";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab5
            // 
            this.lab5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab5.Location = new System.Drawing.Point(353, 95);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(152, 74);
            this.lab5.TabIndex = 7;
            this.lab5.Text = "label5";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 275);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm1";
            this.Text = "学生宿舍管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm1_FormClosing);
            this.Load += new System.EventHandler(this.frm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试数据库连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 范围查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 精确查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出入登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看登记表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
    }
}

