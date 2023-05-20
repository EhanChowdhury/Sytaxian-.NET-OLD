namespace SytaxianInstaller
{
    partial class Installer
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
            this.progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progresslabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.XBorder = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.BorderRadius = 5;
            this.progress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.progress.Location = new System.Drawing.Point(68, 127);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(494, 30);
            this.progress.TabIndex = 0;
            this.progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // progresslabel
            // 
            this.progresslabel.BackColor = System.Drawing.Color.Transparent;
            this.progresslabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresslabel.ForeColor = System.Drawing.Color.Transparent;
            this.progresslabel.Location = new System.Drawing.Point(256, 94);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(109, 27);
            this.progresslabel.TabIndex = 1;
            this.progresslabel.Text = "copying files";
            // 
            // XBorder
            // 
            this.XBorder.BorderRadius = 5;
            this.XBorder.ContainerControl = this;
            this.XBorder.DockIndicatorTransparencyValue = 0.6D;
            this.XBorder.ResizeForm = false;
            this.XBorder.TransparentWhileDrag = true;
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(636, 258);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Installer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Guna.UI2.WinForms.Guna2HtmlLabel progresslabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm XBorder;
    }
}

