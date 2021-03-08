
namespace TextCryption_1._0
{
    partial class Settings
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
            this.lbl_showFont = new System.Windows.Forms.Label();
            this.pnl_showColor = new System.Windows.Forms.Panel();
            this.ftd_font = new System.Windows.Forms.FontDialog();
            this.cld_color = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbl_showFont
            // 
            this.lbl_showFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showFont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showFont.ForeColor = System.Drawing.Color.White;
            this.lbl_showFont.Location = new System.Drawing.Point(12, 9);
            this.lbl_showFont.Name = "lbl_showFont";
            this.lbl_showFont.Size = new System.Drawing.Size(435, 120);
            this.lbl_showFont.TabIndex = 0;
            this.lbl_showFont.Text = "Click to change Font or Background color!\r\nRight click to reset";
            this.lbl_showFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_showFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_showFont_MouseClick);
            // 
            // pnl_showColor
            // 
            this.pnl_showColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_showColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_showColor.Location = new System.Drawing.Point(16, 132);
            this.pnl_showColor.Name = "pnl_showColor";
            this.pnl_showColor.Size = new System.Drawing.Size(431, 103);
            this.pnl_showColor.TabIndex = 1;
            this.pnl_showColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_showColor_MouseClick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(459, 247);
            this.Controls.Add(this.pnl_showColor);
            this.Controls.Add(this.lbl_showFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Settings_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_showFont;
        private System.Windows.Forms.Panel pnl_showColor;
        private System.Windows.Forms.FontDialog ftd_font;
        private System.Windows.Forms.ColorDialog cld_color;
    }
}