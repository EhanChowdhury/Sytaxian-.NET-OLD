namespace Sytaxian
{
    partial class General
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
            this.searchenginebtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // searchenginebtn
            // 
            this.searchenginebtn.BorderRadius = 5;
            this.searchenginebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchenginebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchenginebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchenginebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchenginebtn.FillColor = System.Drawing.Color.Transparent;
            this.searchenginebtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchenginebtn.ForeColor = System.Drawing.Color.White;
            this.searchenginebtn.Image = global::Sytaxian.Properties.Resources.Forward;
            this.searchenginebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchenginebtn.ImageSize = new System.Drawing.Size(35, 35);
            this.searchenginebtn.Location = new System.Drawing.Point(387, 12);
            this.searchenginebtn.Name = "searchenginebtn";
            this.searchenginebtn.Size = new System.Drawing.Size(194, 45);
            this.searchenginebtn.TabIndex = 6;
            this.searchenginebtn.Text = "Search Engine";
            this.searchenginebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchenginebtn.TextOffset = new System.Drawing.Point(-7, 0);
            this.searchenginebtn.Click += new System.EventHandler(this.searchenginebtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Sytaxian.Properties.Resources.Forward;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(387, 78);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(194, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Download Location";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(-7, 0);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.searchenginebtn);
            this.Name = "General";
            this.Size = new System.Drawing.Size(595, 415);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button searchenginebtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
