namespace TimeCodeCounter
{
    partial class SettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox_frame = new System.Windows.Forms.CheckBox();
            this.checkbox_sec = new System.Windows.Forms.CheckBox();
            this.checkbox_min = new System.Windows.Forms.CheckBox();
            this.checkbox_hour = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_init_hour = new System.Windows.Forms.TextBox();
            this.textbox_init_min = new System.Windows.Forms.TextBox();
            this.textbox_init_sec = new System.Windows.Forms.TextBox();
            this.textbox_init_frame = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkbox_dropframe = new System.Windows.Forms.CheckBox();
            this.btn_font_setting = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_forecolor = new System.Windows.Forms.Button();
            this.btn_backgroundcolor = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_custom = new System.Windows.Forms.RadioButton();
            this.rbtn_systemtime = new System.Windows.Forms.RadioButton();
            this.rbtn_random = new System.Windows.Forms.RadioButton();
            this.combobox_framerate = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox_frame);
            this.groupBox1.Controls.Add(this.checkbox_sec);
            this.groupBox1.Controls.Add(this.checkbox_min);
            this.groupBox1.Controls.Add(this.checkbox_hour);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时码显示项";
            // 
            // checkbox_frame
            // 
            this.checkbox_frame.AutoSize = true;
            this.checkbox_frame.Checked = true;
            this.checkbox_frame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_frame.Location = new System.Drawing.Point(9, 86);
            this.checkbox_frame.Name = "checkbox_frame";
            this.checkbox_frame.Size = new System.Drawing.Size(36, 16);
            this.checkbox_frame.TabIndex = 3;
            this.checkbox_frame.Text = "帧";
            this.checkbox_frame.UseVisualStyleBackColor = true;
            this.checkbox_frame.CheckedChanged += new System.EventHandler(this.checkbox_frame_CheckedChanged);
            // 
            // checkbox_sec
            // 
            this.checkbox_sec.AutoSize = true;
            this.checkbox_sec.Checked = true;
            this.checkbox_sec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_sec.Location = new System.Drawing.Point(9, 64);
            this.checkbox_sec.Name = "checkbox_sec";
            this.checkbox_sec.Size = new System.Drawing.Size(36, 16);
            this.checkbox_sec.TabIndex = 3;
            this.checkbox_sec.Text = "秒";
            this.checkbox_sec.UseVisualStyleBackColor = true;
            this.checkbox_sec.CheckedChanged += new System.EventHandler(this.checkbox_sec_CheckedChanged);
            // 
            // checkbox_min
            // 
            this.checkbox_min.AutoSize = true;
            this.checkbox_min.Checked = true;
            this.checkbox_min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_min.Location = new System.Drawing.Point(9, 42);
            this.checkbox_min.Name = "checkbox_min";
            this.checkbox_min.Size = new System.Drawing.Size(48, 16);
            this.checkbox_min.TabIndex = 3;
            this.checkbox_min.Text = "分钟";
            this.checkbox_min.UseVisualStyleBackColor = true;
            this.checkbox_min.CheckedChanged += new System.EventHandler(this.checkbox_min_CheckedChanged);
            // 
            // checkbox_hour
            // 
            this.checkbox_hour.AutoSize = true;
            this.checkbox_hour.Checked = true;
            this.checkbox_hour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_hour.Location = new System.Drawing.Point(9, 20);
            this.checkbox_hour.Name = "checkbox_hour";
            this.checkbox_hour.Size = new System.Drawing.Size(48, 16);
            this.checkbox_hour.TabIndex = 3;
            this.checkbox_hour.Text = "小时";
            this.checkbox_hour.UseVisualStyleBackColor = true;
            this.checkbox_hour.CheckedChanged += new System.EventHandler(this.checkbox_hour_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "帧 率";
            // 
            // textbox_init_hour
            // 
            this.textbox_init_hour.Location = new System.Drawing.Point(13, 46);
            this.textbox_init_hour.MaxLength = 2;
            this.textbox_init_hour.Name = "textbox_init_hour";
            this.textbox_init_hour.Size = new System.Drawing.Size(24, 21);
            this.textbox_init_hour.TabIndex = 15;
            this.textbox_init_hour.Text = "0";
            this.textbox_init_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textbox_init_min
            // 
            this.textbox_init_min.Location = new System.Drawing.Point(53, 46);
            this.textbox_init_min.MaxLength = 2;
            this.textbox_init_min.Name = "textbox_init_min";
            this.textbox_init_min.Size = new System.Drawing.Size(24, 21);
            this.textbox_init_min.TabIndex = 15;
            this.textbox_init_min.Text = "0";
            this.textbox_init_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textbox_init_sec
            // 
            this.textbox_init_sec.Location = new System.Drawing.Point(93, 46);
            this.textbox_init_sec.MaxLength = 2;
            this.textbox_init_sec.Name = "textbox_init_sec";
            this.textbox_init_sec.Size = new System.Drawing.Size(24, 21);
            this.textbox_init_sec.TabIndex = 15;
            this.textbox_init_sec.Text = "0";
            this.textbox_init_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textbox_init_frame
            // 
            this.textbox_init_frame.Location = new System.Drawing.Point(133, 46);
            this.textbox_init_frame.MaxLength = 2;
            this.textbox_init_frame.Name = "textbox_init_frame";
            this.textbox_init_frame.Size = new System.Drawing.Size(32, 21);
            this.textbox_init_frame.TabIndex = 15;
            this.textbox_init_frame.Text = "0";
            this.textbox_init_frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(78, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(38, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(118, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "-";
            // 
            // checkbox_dropframe
            // 
            this.checkbox_dropframe.AutoSize = true;
            this.checkbox_dropframe.Enabled = false;
            this.checkbox_dropframe.Location = new System.Drawing.Point(216, 103);
            this.checkbox_dropframe.Name = "checkbox_dropframe";
            this.checkbox_dropframe.Size = new System.Drawing.Size(84, 16);
            this.checkbox_dropframe.TabIndex = 16;
            this.checkbox_dropframe.Text = "Drop Frame";
            this.checkbox_dropframe.UseVisualStyleBackColor = true;
            // 
            // btn_font_setting
            // 
            this.btn_font_setting.Location = new System.Drawing.Point(315, 12);
            this.btn_font_setting.Name = "btn_font_setting";
            this.btn_font_setting.Size = new System.Drawing.Size(54, 32);
            this.btn_font_setting.TabIndex = 17;
            this.btn_font_setting.Text = "字体";
            this.btn_font_setting.UseVisualStyleBackColor = true;
            this.btn_font_setting.Click += new System.EventHandler(this.btn_font_setting_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(52, 140);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 32);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(257, 140);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 32);
            this.btn_cancle.TabIndex = 19;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_forecolor
            // 
            this.btn_forecolor.Location = new System.Drawing.Point(315, 49);
            this.btn_forecolor.Name = "btn_forecolor";
            this.btn_forecolor.Size = new System.Drawing.Size(54, 32);
            this.btn_forecolor.TabIndex = 21;
            this.btn_forecolor.Text = "前景色";
            this.btn_forecolor.UseVisualStyleBackColor = true;
            this.btn_forecolor.Click += new System.EventHandler(this.btn_forecolor_Click);
            // 
            // btn_backgroundcolor
            // 
            this.btn_backgroundcolor.Location = new System.Drawing.Point(315, 86);
            this.btn_backgroundcolor.Name = "btn_backgroundcolor";
            this.btn_backgroundcolor.Size = new System.Drawing.Size(54, 32);
            this.btn_backgroundcolor.TabIndex = 22;
            this.btn_backgroundcolor.Text = "背景色";
            this.btn_backgroundcolor.UseVisualStyleBackColor = true;
            this.btn_backgroundcolor.Click += new System.EventHandler(this.btn_backgroundcolor_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(154, 140);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 32);
            this.btn_apply.TabIndex = 18;
            this.btn_apply.Text = "应用";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbtn_random);
            this.groupBox2.Controls.Add(this.rbtn_systemtime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbtn_custom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textbox_init_hour);
            this.groupBox2.Controls.Add(this.textbox_init_frame);
            this.groupBox2.Controls.Add(this.textbox_init_min);
            this.groupBox2.Controls.Add(this.textbox_init_sec);
            this.groupBox2.Location = new System.Drawing.Point(103, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 80);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初值设定";
            // 
            // rbtn_custom
            // 
            this.rbtn_custom.AutoSize = true;
            this.rbtn_custom.Checked = true;
            this.rbtn_custom.Location = new System.Drawing.Point(11, 20);
            this.rbtn_custom.Name = "rbtn_custom";
            this.rbtn_custom.Size = new System.Drawing.Size(59, 16);
            this.rbtn_custom.TabIndex = 0;
            this.rbtn_custom.TabStop = true;
            this.rbtn_custom.Text = "自定义";
            this.rbtn_custom.UseVisualStyleBackColor = true;
            this.rbtn_custom.CheckedChanged += new System.EventHandler(this.rbtn_custom_CheckedChanged);
            // 
            // rbtn_systemtime
            // 
            this.rbtn_systemtime.AutoSize = true;
            this.rbtn_systemtime.Location = new System.Drawing.Point(72, 20);
            this.rbtn_systemtime.Name = "rbtn_systemtime";
            this.rbtn_systemtime.Size = new System.Drawing.Size(71, 16);
            this.rbtn_systemtime.TabIndex = 0;
            this.rbtn_systemtime.Text = "系统时间";
            this.rbtn_systemtime.UseVisualStyleBackColor = true;
            this.rbtn_systemtime.CheckedChanged += new System.EventHandler(this.rbtn_systemtime_CheckedChanged);
            // 
            // rbtn_random
            // 
            this.rbtn_random.AutoSize = true;
            this.rbtn_random.Location = new System.Drawing.Point(145, 20);
            this.rbtn_random.Name = "rbtn_random";
            this.rbtn_random.Size = new System.Drawing.Size(47, 16);
            this.rbtn_random.TabIndex = 0;
            this.rbtn_random.Text = "随机";
            this.rbtn_random.UseVisualStyleBackColor = true;
            this.rbtn_random.CheckedChanged += new System.EventHandler(this.rbtn_random_CheckedChanged);
            // 
            // combobox_framerate
            // 
            this.combobox_framerate.FormattingEnabled = true;
            this.combobox_framerate.Items.AddRange(new object[] {
            "15",
            "23.97",
            "24",
            "25",
            "29.97",
            "30",
            "50",
            "60"});
            this.combobox_framerate.Location = new System.Drawing.Point(144, 101);
            this.combobox_framerate.Name = "combobox_framerate";
            this.combobox_framerate.Size = new System.Drawing.Size(60, 20);
            this.combobox_framerate.TabIndex = 24;
            this.combobox_framerate.Text = "25";
            this.combobox_framerate.SelectedIndexChanged += new System.EventHandler(this.combobox_framerate_SelectedIndexChanged);
            this.combobox_framerate.TextChanged += new System.EventHandler(this.combobox_framerate_TextChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 181);
            this.Controls.Add(this.combobox_framerate);
            this.Controls.Add(this.btn_backgroundcolor);
            this.Controls.Add(this.btn_forecolor);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_font_setting);
            this.Controls.Add(this.checkbox_dropframe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingForm";
            this.Text = "时码计数器设置";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox_frame;
        private System.Windows.Forms.CheckBox checkbox_sec;
        private System.Windows.Forms.CheckBox checkbox_min;
        private System.Windows.Forms.CheckBox checkbox_hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_init_hour;
        private System.Windows.Forms.TextBox textbox_init_min;
        private System.Windows.Forms.TextBox textbox_init_sec;
        private System.Windows.Forms.TextBox textbox_init_frame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkbox_dropframe;
        private System.Windows.Forms.Button btn_font_setting;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_forecolor;
        private System.Windows.Forms.Button btn_backgroundcolor;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_random;
        private System.Windows.Forms.RadioButton rbtn_systemtime;
        private System.Windows.Forms.RadioButton rbtn_custom;
        private System.Windows.Forms.ComboBox combobox_framerate;
    }
}