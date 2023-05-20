namespace Sytaxian
{
    partial class adblocker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adblockswitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // adblockswitch
            // 
            this.adblockswitch.Animated = true;
            this.adblockswitch.AutoRoundedCorners = true;
            this.adblockswitch.Checked = true;
            this.adblockswitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adblockswitch.CheckedState.BorderRadius = 16;
            this.adblockswitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adblockswitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.adblockswitch.CheckedState.InnerBorderRadius = 12;
            this.adblockswitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.adblockswitch.Location = new System.Drawing.Point(518, 28);
            this.adblockswitch.Name = "adblockswitch";
            this.adblockswitch.Size = new System.Drawing.Size(64, 34);
            this.adblockswitch.TabIndex = 0;
            this.adblockswitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.adblockswitch.UncheckedState.BorderRadius = 16;
            this.adblockswitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.adblockswitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.adblockswitch.UncheckedState.InnerBorderRadius = 12;
            this.adblockswitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.adblockswitch.CheckedChanged += new System.EventHandler(this.adblockswitch_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(381, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(123, 23);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Enable Adblocker";
            // 
            // adblocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.adblockswitch);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "adblocker";
            this.Size = new System.Drawing.Size(595, 415);
            this.Load += new System.EventHandler(this.adblocker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch adblockswitch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
