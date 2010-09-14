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
            this.label_timeCode = new System.Windows.Forms.Label();
            this.rightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightmenu_start = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_pause = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rightmenu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.rightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_timeCode
            // 
            this.label_timeCode.AutoSize = true;
            this.label_timeCode.ContextMenuStrip = this.rightMenu;
            this.label_timeCode.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timeCode.Location = new System.Drawing.Point(2, 1);
            this.label_timeCode.Name = "label_timeCode";
            this.label_timeCode.Size = new System.Drawing.Size(581, 97);
            this.label_timeCode.TabIndex = 0;
            this.label_timeCode.Text = "12:34:56:78";
            this.label_timeCode.Click += new System.EventHandler(this.label_timeCode_Click);
            // 
            // rightMenu
            // 
            this.rightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightmenu_start,
            this.rightmenu_pause,
            this.rightmenu_reset,
            this.rightmenu_close,
            this.toolStripSeparator1,
            this.rightmenu_setting,
            this.rightmenu_about});
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.Size = new System.Drawing.Size(136, 142);
            this.rightMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightMenu_Opening);
            // 
            // rightmenu_start
            // 
            this.rightmenu_start.Name = "rightmenu_start";
            this.rightmenu_start.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.rightmenu_start.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_start.Text = "开始";
            this.rightmenu_start.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rightmenu_pause
            // 
            this.rightmenu_pause.Name = "rightmenu_pause";
            this.rightmenu_pause.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_pause.Text = "暂停";
            // 
            // rightmenu_reset
            // 
            this.rightmenu_reset.Name = "rightmenu_reset";
            this.rightmenu_reset.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_reset.Text = "复位";
            // 
            // rightmenu_close
            // 
            this.rightmenu_close.Name = "rightmenu_close";
            this.rightmenu_close.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_close.Text = "关闭";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // rightmenu_setting
            // 
            this.rightmenu_setting.Name = "rightmenu_setting";
            this.rightmenu_setting.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_setting.Text = "设置";
            this.rightmenu_setting.Click += new System.EventHandler(this.rightmenu_setting_Click);
            // 
            // rightmenu_about
            // 
            this.rightmenu_about.Name = "rightmenu_about";
            this.rightmenu_about.Size = new System.Drawing.Size(135, 22);
            this.rightmenu_about.Text = "关于";
            // 
            // form_timeCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 104);
            this.ContextMenuStrip = this.rightMenu;
            this.Controls.Add(this.label_timeCode);
            this.Name = "form_timeCode";
            this.Text = "时码计数器";
            this.Load += new System.EventHandler(this.form_timeCode_load);
            this.rightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_timeCode;
        private System.Windows.Forms.ContextMenuStrip rightMenu;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_start;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_pause;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_setting;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_about;
        private System.Windows.Forms.ToolStripMenuItem rightmenu_close;

    }
}

