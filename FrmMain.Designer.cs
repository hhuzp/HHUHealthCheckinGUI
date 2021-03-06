﻿namespace HHUCheckin
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Checkin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.Chk_Rememberme = new System.Windows.Forms.CheckBox();
            this.LoopTimer = new System.Windows.Forms.Timer(this.components);
            this.Chk_AutoCheckin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_LastCheckinTime = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Chk_SendMail = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(70, 12);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(164, 25);
            this.Txt_Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(70, 50);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(164, 25);
            this.Txt_Password.TabIndex = 3;
            // 
            // Btn_Checkin
            // 
            this.Btn_Checkin.Location = new System.Drawing.Point(249, 11);
            this.Btn_Checkin.Name = "Btn_Checkin";
            this.Btn_Checkin.Size = new System.Drawing.Size(146, 98);
            this.Btn_Checkin.TabIndex = 4;
            this.Btn_Checkin.Text = "打卡";
            this.Btn_Checkin.UseVisualStyleBackColor = true;
            this.Btn_Checkin.Click += new System.EventHandler(this.Btn_Checkin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "状态：";
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_Status.Location = new System.Drawing.Point(67, 191);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(82, 15);
            this.Lbl_Status.TabIndex = 8;
            this.Lbl_Status.Text = "初始化完成";
            // 
            // Chk_Rememberme
            // 
            this.Chk_Rememberme.AutoSize = true;
            this.Chk_Rememberme.Checked = true;
            this.Chk_Rememberme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Rememberme.Location = new System.Drawing.Point(12, 125);
            this.Chk_Rememberme.Name = "Chk_Rememberme";
            this.Chk_Rememberme.Size = new System.Drawing.Size(74, 19);
            this.Chk_Rememberme.TabIndex = 9;
            this.Chk_Rememberme.Text = "记住我";
            this.Chk_Rememberme.UseVisualStyleBackColor = true;
            // 
            // LoopTimer
            // 
            this.LoopTimer.Enabled = true;
            this.LoopTimer.Interval = 60000;
            this.LoopTimer.Tick += new System.EventHandler(this.LoopTimer_Tick);
            // 
            // Chk_AutoCheckin
            // 
            this.Chk_AutoCheckin.AutoSize = true;
            this.Chk_AutoCheckin.Checked = true;
            this.Chk_AutoCheckin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_AutoCheckin.Location = new System.Drawing.Point(93, 125);
            this.Chk_AutoCheckin.Name = "Chk_AutoCheckin";
            this.Chk_AutoCheckin.Size = new System.Drawing.Size(89, 19);
            this.Chk_AutoCheckin.TabIndex = 10;
            this.Chk_AutoCheckin.Text = "自动打卡";
            this.Chk_AutoCheckin.UseVisualStyleBackColor = true;
            this.Chk_AutoCheckin.Click += new System.EventHandler(this.Chk_AutoCheckin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "上一次打卡时间：";
            // 
            // Lbl_LastCheckinTime
            // 
            this.Lbl_LastCheckinTime.AutoSize = true;
            this.Lbl_LastCheckinTime.ForeColor = System.Drawing.Color.Black;
            this.Lbl_LastCheckinTime.Location = new System.Drawing.Point(145, 161);
            this.Lbl_LastCheckinTime.Name = "Lbl_LastCheckinTime";
            this.Lbl_LastCheckinTime.Size = new System.Drawing.Size(37, 15);
            this.Lbl_LastCheckinTime.TabIndex = 12;
            this.Lbl_LastCheckinTime.Text = "未知";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(70, 85);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(164, 25);
            this.Txt_Email.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "邮箱：";
            // 
            // Chk_SendMail
            // 
            this.Chk_SendMail.AutoSize = true;
            this.Chk_SendMail.Location = new System.Drawing.Point(188, 125);
            this.Chk_SendMail.Name = "Chk_SendMail";
            this.Chk_SendMail.Size = new System.Drawing.Size(149, 19);
            this.Chk_SendMail.TabIndex = 15;
            this.Chk_SendMail.Text = "打卡结果发送邮箱";
            this.Chk_SendMail.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "程序已最小化到托盘";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HHUCheckin v2";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.Chk_SendMail);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_LastCheckinTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Chk_AutoCheckin);
            this.Controls.Add(this.Chk_Rememberme);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Checkin);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "HHUCheckin v2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Checkin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.CheckBox Chk_Rememberme;
        private System.Windows.Forms.Timer LoopTimer;
        private System.Windows.Forms.CheckBox Chk_AutoCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_LastCheckinTime;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Chk_SendMail;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

