namespace Sytaxian
{
    partial class SE
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
            this.color_er = new System.Windows.Forms.Panel();
            this.Urltb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Border = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.sve = new Guna.UI2.WinForms.Guna2Button();
            this.reset = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // color_er
            // 
            this.color_er.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.color_er.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.color_er.Location = new System.Drawing.Point(0, 113);
            this.color_er.Name = "color_er";
            this.color_er.Size = new System.Drawing.Size(405, 35);
            this.color_er.TabIndex = 0;
            // 
            // Urltb
            // 
            this.Urltb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.Urltb.BorderRadius = 4;
            this.Urltb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Urltb.DefaultText = "";
            this.Urltb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Urltb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Urltb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Urltb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Urltb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.Urltb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Urltb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urltb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Urltb.Location = new System.Drawing.Point(7, 8);
            this.Urltb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Urltb.Name = "Urltb";
            this.Urltb.PasswordChar = '\0';
            this.Urltb.PlaceholderText = "URL";
            this.Urltb.SelectedText = "";
            this.Urltb.Size = new System.Drawing.Size(170, 40);
            this.Urltb.TabIndex = 1;
            // 
            // Border
            // 
            this.Border.BorderRadius = 5;
            this.Border.ContainerControl = this;
            this.Border.DockIndicatorTransparencyValue = 0.6D;
            this.Border.ResizeForm = false;
            this.Border.TransparentWhileDrag = true;
            // 
            // sve
            // 
            this.sve.BorderRadius = 5;
            this.sve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sve.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.sve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sve.ForeColor = System.Drawing.Color.White;
            this.sve.Location = new System.Drawing.Point(3, 55);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(180, 45);
            this.sve.TabIndex = 3;
            this.sve.Text = "Save";
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // reset
            // 
            this.reset.BorderRadius = 5;
            this.reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(206, 55);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(180, 45);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // SE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(405, 148);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.Urltb);
            this.Controls.Add(this.color_er);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel color_er;
        private Guna.UI2.WinForms.Guna2TextBox Urltb;
        private Guna.UI2.WinForms.Guna2BorderlessForm Border;
        private Guna.UI2.WinForms.Guna2Button reset;
        private Guna.UI2.WinForms.Guna2Button sve;
    }
}