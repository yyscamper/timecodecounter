namespace TimeCodeCounter
{
    partial class form_timeCode
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightmenu_start = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_pause = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rightmenu_topmost = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.label_timeCode = new System.Windows.Forms.Label();
            this.rightmenu_hideTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.rightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightMenu
            // 
            this.rightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightmenu_start,
            this.toolStripMenuItem1,
            this.rightmenu_pause,
            this.rightmenu_reset,
            this.toolStripSeparator1,
            this.rightmenu_hideTitle,
            this.rightmenu_topmost,
            this.rightmenu_setting,
            this.rightmenu_about,
            this.rightmenu_close});
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.Size = new System.Drawing.Size(166, 208);
            this.rightMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightMenu_Opening);
            // 
            // rightmenu_start
            // 
            this.rightmenu_start.Name = "rightmenu_start";
            this.rightmenu_start.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.rightmenu_start.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_start.Text = "开始";
            this.rightmenu_start.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "停止";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // rightmenu_pause
            // 
            this.rightmenu_pause.Name = "rightmenu_pause";
            this.rightmenu_pause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.rightmenu_pause.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_pause.Text = "暂停";
            this.rightmenu_pause.Click += new System.EventHandler(this.rightmenu_pause_Click);
            // 
            // rightmenu_reset
            // 
            this.rightmenu_reset.Name = "rightmenu_reset";
            this.rightmenu_reset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rightmenu_reset.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_reset.Text = "重新开始";
            this.rightmenu_reset.Click += new System.EventHandler(this.rightmenu_reset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // rightmenu_topmost
            // 
            this.rightmenu_topmost.Name = "rightmenu_topmost";
            this.rightmenu_topmost.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.rightmenu_topmost.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_topmost.Text = "置顶";
            this.rightmenu_topmost.Click += new System.EventHandler(this.rightmenu_topmost_Click);
            // 
            // rightmenu_setting
            // 
            this.rightmenu_setting.Name = "rightmenu_setting";
            this.rightmenu_setting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.rightmenu_setting.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_setting.Text = "设置";
            this.rightmenu_setting.Click += new System.EventHandler(this.rightmenu_setting_Click);
            // 
            // rightmenu_about
            // 
            this.rightmenu_about.Name = "rightmenu_about";
            this.rightmenu_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.rightmenu_about.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_about.Text = "关于";
            this.rightmenu_about.Click += new System.EventHandler(this.rightmenu_about_Click);
            // 
            // rightmenu_close
            // 
            this.rightmenu_close.Name = "rightmenu_close";
            this.rightmenu_close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.rightmenu_close.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_close.Text = "退出";
            this.rightmenu_close.Click += new System.EventHandler(this.rightmenu_close_Click);
            // 
            // label_timeCode
            // 
            this.label_timeCode.AutoSize = true;
            this.label_timeCode.ContextMenuStrip = this.rightMenu;
            this.label_timeCode.Font = new System.Drawing.Font("宋体", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timeCode.Location = new System.Drawing.Point(0, 0);
            this.label_timeCode.Margin = new System.Windows.Forms.Padding(0);
            this.label_timeCode.Name = "label_timeCode";
            this.label_timeCode.Size = new System.Drawing.Size(805, 133);
            this.label_timeCode.TabIndex = 0;
            this.label_timeCode.Text = "00:00:00-00";
            this.label_timeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_timeCode.Click += new System.EventHandler(this.label_timeCode_Click);
            // 
            // rightmenu_hideTitle
            // 
            this.rightmenu_hideTitle.Name = "rightmenu_hideTitle";
            this.rightmenu_hideTitle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.rightmenu_hideTitle.Size = new System.Drawing.Size(165, 22);
            this.rightmenu_hideTitle.Text = "隐藏标题栏";
            this.rightmenu_hideTitle.Click += new System.EventHandler(this.rightmenu_hideTitle_Click_1);
            // 
            // form_timeCode
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 136);
            this.ContextMenuStrip = this.rightMenu;
            this.Controls.Add(this.label_timeCode);
            this.Name = "form_timeCode";
            this.Text = "时码计数器";
            this.Load += new System.EventHandler(this.form_timeCode_load);
            this.SizeChanged += new System.EventHandler(this.form_timeCode_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_timeCode_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_timeCode_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_timeCode_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_timeCode_KeyDown);
            this.rightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip rightMenu;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_start;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_pause;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_setting;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_about;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_close;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label_timeCode;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_topmost;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_hideTitle;

    }
}

