namespace Sytaxian
{
    partial class Sytaxian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sytaxian));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.RemoveFocus = new System.Windows.Forms.RadioButton();
            this.UrlTextbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.settingsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.forward = new Guna.UI2.WinForms.Guna2CircleButton();
            this.back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SP = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Controls.Add(this.RemoveFocus);
            this.mainpanel.Location = new System.Drawing.Point(0, 45);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 406);
            this.mainpanel.TabIndex = 0;
            // 
            // RemoveFocus
            // 
            this.RemoveFocus.AutoSize = true;
            this.RemoveFocus.Location = new System.Drawing.Point(1900, 95);
            this.RemoveFocus.Name = "RemoveFocus";
            this.RemoveFocus.Size = new System.Drawing.Size(14, 13);
            this.RemoveFocus.TabIndex = 0;
            this.RemoveFocus.TabStop = true;
            this.RemoveFocus.UseVisualStyleBackColor = true;
            // 
            // UrlTextbx
            // 
            this.UrlTextbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTextbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.UrlTextbx.BorderRadius = 10;
            this.UrlTextbx.BorderThickness = 2;
            this.UrlTextbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UrlTextbx.DefaultText = "";
            this.UrlTextbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UrlTextbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UrlTextbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UrlTextbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UrlTextbx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.UrlTextbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UrlTextbx.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UrlTextbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UrlTextbx.Location = new System.Drawing.Point(100, 4);
            this.UrlTextbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrlTextbx.Name = "UrlTextbx";
            this.UrlTextbx.PasswordChar = '\0';
            this.UrlTextbx.PlaceholderText = "Search Or Type an URL";
            this.UrlTextbx.SelectedText = "";
            this.UrlTextbx.Size = new System.Drawing.Size(693, 36);
            this.UrlTextbx.TabIndex = 1;
            this.UrlTextbx.TextOffset = new System.Drawing.Point(30, 0);
            this.UrlTextbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlTextbx_KeyPress);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.settingsbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsbtn.ForeColor = System.Drawing.Color.White;
            this.settingsbtn.Image = global::Sytaxian.Properties.Resources.icons8_settings_64;
            this.settingsbtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.settingsbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.settingsbtn.Location = new System.Drawing.Point(752, 7);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(34, 30);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // forward
            // 
            this.forward.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.forward.DisabledState.Image = global::Sytaxian.Properties.Resources.Forward;
            this.forward.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.forward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forward.ForeColor = System.Drawing.Color.White;
            this.forward.Image = global::Sytaxian.Properties.Resources.Forward;
            this.forward.ImageOffset = new System.Drawing.Point(2, 0);
            this.forward.ImageSize = new System.Drawing.Size(40, 40);
            this.forward.Location = new System.Drawing.Point(54, 5);
            this.forward.Name = "forward";
            this.forward.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.forward.Size = new System.Drawing.Size(40, 36);
            this.forward.TabIndex = 3;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.back.DisabledState.Image = global::Sytaxian.Properties.Resources.Back;
            this.back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = global::Sytaxian.Properties.Resources.Back;
            this.back.ImageOffset = new System.Drawing.Point(-2, 0);
            this.back.ImageSize = new System.Drawing.Size(40, 40);
            this.back.Location = new System.Drawing.Point(6, 5);
            this.back.Name = "back";
            this.back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.back.Size = new System.Drawing.Size(40, 36);
            this.back.TabIndex = 2;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SP
            // 
            this.SP.BackColor = System.Drawing.Color.Transparent;
            this.SP.Image = global::Sytaxian.Properties.Resources.windows_defender_48px;
            this.SP.ImageRotate = 0F;
            this.SP.Location = new System.Drawing.Point(108, 7);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(30, 30);
            this.SP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SP.TabIndex = 4;
            this.SP.TabStop = false;
            this.SP.UseTransparentBackground = true;
            // 
            // Sytaxian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.settingsbtn);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.UrlTextbx);
            this.Controls.Add(this.mainpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sytaxian";
            this.Text = "Sytaxian";
            this.Load += new System.EventHandler(this.Sytaxian_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private Guna.UI2.WinForms.Guna2TextBox UrlTextbx;
        private System.Windows.Forms.RadioButton RemoveFocus;
        private Guna.UI2.WinForms.Guna2CircleButton back;
        private Guna.UI2.WinForms.Guna2CircleButton forward;
        private Guna.UI2.WinForms.Guna2Button settingsbtn;
        private Guna.UI2.WinForms.Guna2PictureBox SP;
    }
}

