﻿namespace Promotive_Promosyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.giriş_Button = new System.Windows.Forms.Button();
            this.password = new ns1.BunifuTextbox();
            this.username = new ns1.BunifuTextbox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.kayitol_Button = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mini_Button = new ns1.BunifuImageButton();
            this.kapat_Button = new ns1.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat_Button)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.Vertical = true;
            // 
            // giriş_Button
            // 
            this.giriş_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.giriş_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.giriş_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giriş_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giriş_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriş_Button.ForeColor = System.Drawing.Color.White;
            this.giriş_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giriş_Button.Location = new System.Drawing.Point(339, 309);
            this.giriş_Button.Name = "giriş_Button";
            this.giriş_Button.Size = new System.Drawing.Size(168, 50);
            this.giriş_Button.TabIndex = 2;
            this.giriş_Button.Text = "Giriş Yap";
            this.giriş_Button.UseVisualStyleBackColor = false;
            this.giriş_Button.Click += new System.EventHandler(this.giriş_Button_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password.BackgroundImage")));
            this.password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.password.Icon = ((System.Drawing.Image)(resources.GetObject("password.Icon")));
            this.password.Location = new System.Drawing.Point(300, 233);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(280, 39);
            this.password.TabIndex = 2;
            this.password.text = "";
            this.password.OnTextChange += new System.EventHandler(this.password_OnTextChange);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username.BackgroundImage")));
            this.username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.username.Icon = ((System.Drawing.Image)(resources.GetObject("username.Icon")));
            this.username.Location = new System.Drawing.Point(300, 185);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(280, 39);
            this.username.TabIndex = 0;
            this.username.text = "";
            this.username.OnTextChange += new System.EventHandler(this.username_OnTextChange);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(253, 80);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(338, 74);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 14;
            this.bunifuElipse2.TargetControl = this.giriş_Button;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(13, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Promotive Promosyon &  Ajans © Copyright 2018";
            // 
            // kayitol_Button
            // 
            this.kayitol_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.kayitol_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kayitol_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitol_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitol_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitol_Button.ForeColor = System.Drawing.Color.White;
            this.kayitol_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayitol_Button.Location = new System.Drawing.Point(663, 444);
            this.kayitol_Button.Name = "kayitol_Button";
            this.kayitol_Button.Size = new System.Drawing.Size(126, 34);
            this.kayitol_Button.TabIndex = 2;
            this.kayitol_Button.Text = "Kayıt Ol";
            this.kayitol_Button.UseVisualStyleBackColor = false;
            this.kayitol_Button.Click += new System.EventHandler(this.giriş_Button_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 14;
            this.bunifuElipse3.TargetControl = this.kayitol_Button;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(250, 465);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Web Sitemiz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(569, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesabın Yokmu?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(577, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hemen Kayıt Ol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(336, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(336, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şifre";
            // 
            // mini_Button
            // 
            this.mini_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.mini_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_Button.Image = ((System.Drawing.Image)(resources.GetObject("mini_Button.Image")));
            this.mini_Button.ImageActive = null;
            this.mini_Button.Location = new System.Drawing.Point(713, 3);
            this.mini_Button.Name = "mini_Button";
            this.mini_Button.Size = new System.Drawing.Size(35, 34);
            this.mini_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_Button.TabIndex = 2;
            this.mini_Button.TabStop = false;
            this.mini_Button.Zoom = 10;
            // 
            // kapat_Button
            // 
            this.kapat_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.kapat_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat_Button.Image = ((System.Drawing.Image)(resources.GetObject("kapat_Button.Image")));
            this.kapat_Button.ImageActive = null;
            this.kapat_Button.Location = new System.Drawing.Point(754, 2);
            this.kapat_Button.Name = "kapat_Button";
            this.kapat_Button.Size = new System.Drawing.Size(35, 34);
            this.kapat_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kapat_Button.TabIndex = 1;
            this.kapat_Button.TabStop = false;
            this.kapat_Button.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.mini_Button);
            this.panel1.Controls.Add(this.kapat_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 36);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitol_Button);
            this.Controls.Add(this.giriş_Button);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotive Promosyon ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat_Button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox logo;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button giriş_Button;
        private ns1.BunifuTextbox password;
        private ns1.BunifuTextbox username;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitol_Button;
        private ns1.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton mini_Button;
        private ns1.BunifuImageButton kapat_Button;
    }
}

