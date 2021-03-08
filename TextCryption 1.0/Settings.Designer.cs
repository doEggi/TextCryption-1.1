
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_showFont = new System.Windows.Forms.Label();
            this.pnl_showColor = new System.Windows.Forms.Panel();
            this.ftd_font = new System.Windows.Forms.FontDialog();
            this.cld_color = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbl_showFont
            // 
            resources.ApplyResources(this.lbl_showFont, "lbl_showFont");
            this.lbl_showFont.ForeColor = System.Drawing.Color.White;
            this.lbl_showFont.Name = "lbl_showFont";
            this.lbl_showFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_showFont_MouseClick);
            // 
            // pnl_showColor
            // 
            resources.ApplyResources(this.pnl_showColor, "pnl_showColor");
            this.pnl_showColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_showColor.Name = "pnl_showColor";
            this.pnl_showColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_showColor_MouseClick);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pnl_showColor);
            this.Controls.Add(this.lbl_showFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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