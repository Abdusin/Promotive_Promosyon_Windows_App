namespace Promotive_Promosyon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat_Button = new ns1.BunifuImageButton();
            this.mini_Button = new ns1.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainmenu_Button = new ns1.BunifuFlatButton();
            this.categories_button = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.parabirim_Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapat_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.parabirim_Box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kapat_Button);
            this.panel1.Controls.Add(this.mini_Button);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 53);
            this.panel1.TabIndex = 5;
            // 
            // kapat_Button
            // 
            this.kapat_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.kapat_Button.Image = ((System.Drawing.Image)(resources.GetObject("kapat_Button.Image")));
            this.kapat_Button.ImageActive = null;
            this.kapat_Button.Location = new System.Drawing.Point(825, 0);
            this.kapat_Button.Name = "kapat_Button";
            this.kapat_Button.Size = new System.Drawing.Size(57, 51);
            this.kapat_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kapat_Button.TabIndex = 7;
            this.kapat_Button.TabStop = false;
            this.kapat_Button.Zoom = 10;
            this.kapat_Button.Click += new System.EventHandler(this.kapat_Button_Click);
            // 
            // mini_Button
            // 
            this.mini_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.mini_Button.Image = ((System.Drawing.Image)(resources.GetObject("mini_Button.Image")));
            this.mini_Button.ImageActive = null;
            this.mini_Button.Location = new System.Drawing.Point(765, -1);
            this.mini_Button.Name = "mini_Button";
            this.mini_Button.Size = new System.Drawing.Size(54, 51);
            this.mini_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_Button.TabIndex = 2;
            this.mini_Button.TabStop = false;
            this.mini_Button.Zoom = 10;
            this.mini_Button.Click += new System.EventHandler(this.mini_Button_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(3, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(226, 54);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
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
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.categories_button);
            this.panel2.Controls.Add(this.mainmenu_Button);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 459);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.avatar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 62);
            this.panel3.TabIndex = 1;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(3, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(56, 56);
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // mainmenu_Button
            // 
            this.mainmenu_Button.Activecolor = System.Drawing.Color.DimGray;
            this.mainmenu_Button.BackColor = System.Drawing.Color.Gray;
            this.mainmenu_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainmenu_Button.BorderRadius = 0;
            this.mainmenu_Button.ButtonText = "Ana Menü";
            this.mainmenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenu_Button.DisabledColor = System.Drawing.Color.Gray;
            this.mainmenu_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.mainmenu_Button.Iconimage = ((System.Drawing.Image)(resources.GetObject("mainmenu_Button.Iconimage")));
            this.mainmenu_Button.Iconimage_right = null;
            this.mainmenu_Button.Iconimage_right_Selected = null;
            this.mainmenu_Button.Iconimage_Selected = null;
            this.mainmenu_Button.IconMarginLeft = 0;
            this.mainmenu_Button.IconMarginRight = 0;
            this.mainmenu_Button.IconRightVisible = true;
            this.mainmenu_Button.IconRightZoom = 0D;
            this.mainmenu_Button.IconVisible = true;
            this.mainmenu_Button.IconZoom = 90D;
            this.mainmenu_Button.IsTab = false;
            this.mainmenu_Button.Location = new System.Drawing.Point(3, 7);
            this.mainmenu_Button.Name = "mainmenu_Button";
            this.mainmenu_Button.Normalcolor = System.Drawing.Color.Gray;
            this.mainmenu_Button.OnHovercolor = System.Drawing.Color.DimGray;
            this.mainmenu_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.mainmenu_Button.selected = false;
            this.mainmenu_Button.Size = new System.Drawing.Size(200, 49);
            this.mainmenu_Button.TabIndex = 0;
            this.mainmenu_Button.Text = "Ana Menü";
            this.mainmenu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainmenu_Button.Textcolor = System.Drawing.Color.White;
            this.mainmenu_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // categories_button
            // 
            this.categories_button.Activecolor = System.Drawing.Color.DimGray;
            this.categories_button.BackColor = System.Drawing.Color.Gray;
            this.categories_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categories_button.BorderRadius = 0;
            this.categories_button.ButtonText = "Katagoriler";
            this.categories_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categories_button.DisabledColor = System.Drawing.Color.Gray;
            this.categories_button.Iconcolor = System.Drawing.Color.Transparent;
            this.categories_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("categories_button.Iconimage")));
            this.categories_button.Iconimage_right = null;
            this.categories_button.Iconimage_right_Selected = null;
            this.categories_button.Iconimage_Selected = null;
            this.categories_button.IconMarginLeft = 0;
            this.categories_button.IconMarginRight = 0;
            this.categories_button.IconRightVisible = true;
            this.categories_button.IconRightZoom = 0D;
            this.categories_button.IconVisible = true;
            this.categories_button.IconZoom = 90D;
            this.categories_button.IsTab = false;
            this.categories_button.Location = new System.Drawing.Point(3, 62);
            this.categories_button.Name = "categories_button";
            this.categories_button.Normalcolor = System.Drawing.Color.Gray;
            this.categories_button.OnHovercolor = System.Drawing.Color.DimGray;
            this.categories_button.OnHoverTextColor = System.Drawing.Color.White;
            this.categories_button.selected = false;
            this.categories_button.Size = new System.Drawing.Size(200, 49);
            this.categories_button.TabIndex = 0;
            this.categories_button.Text = "Katagoriler";
            this.categories_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categories_button.Textcolor = System.Drawing.Color.White;
            this.categories_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Ana Menü";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 117);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(200, 49);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Text = "Ana Menü";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(686, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Para Birimi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // parabirim_Box
            // 
            this.parabirim_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.parabirim_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parabirim_Box.ForeColor = System.Drawing.Color.White;
            this.parabirim_Box.FormattingEnabled = true;
            this.parabirim_Box.Location = new System.Drawing.Point(689, 25);
            this.parabirim_Box.Name = "parabirim_Box";
            this.parabirim_Box.Size = new System.Drawing.Size(70, 21);
            this.parabirim_Box.TabIndex = 7;
            this.parabirim_Box.SelectedIndexChanged += new System.EventHandler(this.parabirim_Box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "USER";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotive Promosyon ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapat_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton mini_Button;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuImageButton kapat_Button;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuFlatButton mainmenu_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton categories_button;
        private System.Windows.Forms.ComboBox parabirim_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}