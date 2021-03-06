
namespace TextCryption_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sts = new System.Windows.Forms.StatusStrip();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tls = new System.Windows.Forms.ToolStrip();
            this.tsb_open = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_saveAll = new System.Windows.Forms.ToolStripButton();
            this.tsb_import = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.txb_text = new System.Windows.Forms.TextBox();
            this.ofd_open = new System.Windows.Forms.OpenFileDialog();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.chb_showPassword = new System.Windows.Forms.CheckBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.lbl_titlePassword = new System.Windows.Forms.Label();
            this.sfd_safeAt = new System.Windows.Forms.SaveFileDialog();
            this.ofd_textFiles = new System.Windows.Forms.OpenFileDialog();
            this.ftd_font = new System.Windows.Forms.FontDialog();
            this.tsb_font = new System.Windows.Forms.ToolStripButton();
            this.sts.SuspendLayout();
            this.tls.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts
            // 
            this.sts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sts.AutoSize = false;
            this.sts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sts.Dock = System.Windows.Forms.DockStyle.None;
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_status});
            this.sts.Location = new System.Drawing.Point(0, 425);
            this.sts.Name = "sts";
            this.sts.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sts.Size = new System.Drawing.Size(797, 22);
            this.sts.TabIndex = 1;
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(114, 17);
            this.tssl_status.Text = "Keine Datei geöffnet";
            // 
            // tls
            // 
            this.tls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tls.AutoSize = false;
            this.tls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tls.Dock = System.Windows.Forms.DockStyle.None;
            this.tls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_open,
            this.tsb_save,
            this.tsb_saveAll,
            this.tsb_import,
            this.tsb_font,
            this.tsb_close});
            this.tls.Location = new System.Drawing.Point(-1, -1);
            this.tls.Name = "tls";
            this.tls.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls.Size = new System.Drawing.Size(798, 25);
            this.tls.TabIndex = 2;
            // 
            // tsb_open
            // 
            this.tsb_open.Image = ((System.Drawing.Image)(resources.GetObject("tsb_open.Image")));
            this.tsb_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_open.Name = "tsb_open";
            this.tsb_open.Size = new System.Drawing.Size(64, 22);
            this.tsb_open.Text = "Öffnen\t";
            this.tsb_open.ToolTipText = "Öffnen";
            this.tsb_open.Click += new System.EventHandler(this.tsb_open_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(79, 22);
            this.tsb_save.Text = "Speichern";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_saveAll
            // 
            this.tsb_saveAll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_saveAll.Image")));
            this.tsb_saveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_saveAll.Name = "tsb_saveAll";
            this.tsb_saveAll.Size = new System.Drawing.Size(119, 22);
            this.tsb_saveAll.Text = "Speichern unter...";
            this.tsb_saveAll.Click += new System.EventHandler(this.tsb_saveAll_Click);
            // 
            // tsb_import
            // 
            this.tsb_import.Image = ((System.Drawing.Image)(resources.GetObject("tsb_import.Image")));
            this.tsb_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_import.Name = "tsb_import";
            this.tsb_import.Size = new System.Drawing.Size(98, 22);
            this.tsb_import.Text = "Importieren...";
            this.tsb_import.Click += new System.EventHandler(this.tsb_import_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(78, 22);
            this.tsb_close.Text = "Schließen\t";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // txb_text
            // 
            this.txb_text.AcceptsTab = true;
            this.txb_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_text.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txb_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_text.Location = new System.Drawing.Point(2, 28);
            this.txb_text.Multiline = true;
            this.txb_text.Name = "txb_text";
            this.txb_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_text.Size = new System.Drawing.Size(792, 395);
            this.txb_text.TabIndex = 3;
            this.txb_text.TextChanged += new System.EventHandler(this.txb_text_TextChanged);
            this.txb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_text_KeyDown);
            this.txb_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_text_KeyPress);
            // 
            // ofd_open
            // 
            this.ofd_open.Filter = "Verschlüsselte Textdateien|*.enct";
            this.ofd_open.Title = "Verschlüsselte Datei öffnen...";
            // 
            // pnl_password
            // 
            this.pnl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_password.Controls.Add(this.chb_showPassword);
            this.pnl_password.Controls.Add(this.txb_password);
            this.pnl_password.Controls.Add(this.lbl_titlePassword);
            this.pnl_password.Location = new System.Drawing.Point(2, 28);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(792, 395);
            this.pnl_password.TabIndex = 4;
            this.pnl_password.Visible = false;
            // 
            // chb_showPassword
            // 
            this.chb_showPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chb_showPassword.AutoSize = true;
            this.chb_showPassword.Location = new System.Drawing.Point(240, 202);
            this.chb_showPassword.Name = "chb_showPassword";
            this.chb_showPassword.Size = new System.Drawing.Size(115, 17);
            this.chb_showPassword.TabIndex = 2;
            this.chb_showPassword.Text = "Passwort anzeigen";
            this.chb_showPassword.UseVisualStyleBackColor = true;
            this.chb_showPassword.CheckedChanged += new System.EventHandler(this.chb_showPassword_CheckedChanged);
            // 
            // txb_password
            // 
            this.txb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txb_password.Location = new System.Drawing.Point(240, 176);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(374, 20);
            this.txb_password.TabIndex = 1;
            this.txb_password.UseSystemPasswordChar = true;
            this.txb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_password_KeyPress);
            // 
            // lbl_titlePassword
            // 
            this.lbl_titlePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_titlePassword.AutoSize = true;
            this.lbl_titlePassword.Location = new System.Drawing.Point(178, 179);
            this.lbl_titlePassword.Name = "lbl_titlePassword";
            this.lbl_titlePassword.Size = new System.Drawing.Size(56, 13);
            this.lbl_titlePassword.TabIndex = 0;
            this.lbl_titlePassword.Text = "Passwort: ";
            // 
            // sfd_safeAt
            // 
            this.sfd_safeAt.Filter = "Verschlüsselte Textdateien|*.enct";
            this.sfd_safeAt.Title = "Datei speichern unter...";
            // 
            // ofd_textFiles
            // 
            this.ofd_textFiles.Filter = "Textdatei|*.txt";
            this.ofd_textFiles.Title = "Textdatei importieren...";
            // 
            // tsb_font
            // 
            this.tsb_font.Image = ((System.Drawing.Image)(resources.GetObject("tsb_font.Image")));
            this.tsb_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_font.Name = "tsb_font";
            this.tsb_font.Size = new System.Drawing.Size(75, 22);
            this.tsb_font.Text = "Schriftart";
            this.tsb_font.Click += new System.EventHandler(this.tsb_font_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(796, 447);
            this.Controls.Add(this.pnl_password);
            this.Controls.Add(this.txb_text);
            this.Controls.Add(this.tls);
            this.Controls.Add(this.sts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(310, 200);
            this.Name = "Form1";
            this.Text = "TextCryption 1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.sts.ResumeLayout(false);
            this.sts.PerformLayout();
            this.tls.ResumeLayout(false);
            this.tls.PerformLayout();
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
        private System.Windows.Forms.ToolStrip tls;
        private System.Windows.Forms.ToolStripButton tsb_open;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.TextBox txb_text;
        private System.Windows.Forms.OpenFileDialog ofd_open;
        private System.Windows.Forms.ToolStripButton tsb_saveAll;
        private System.Windows.Forms.ToolStripButton tsb_import;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.CheckBox chb_showPassword;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label lbl_titlePassword;
        private System.Windows.Forms.SaveFileDialog sfd_safeAt;
        private System.Windows.Forms.OpenFileDialog ofd_textFiles;
        private System.Windows.Forms.ToolStripButton tsb_font;
        private System.Windows.Forms.FontDialog ftd_font;
    }
}

