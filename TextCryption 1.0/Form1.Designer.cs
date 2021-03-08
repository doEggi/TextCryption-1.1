
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
            this.tsb_info = new System.Windows.Forms.ToolStripButton();
            this.txb_text = new System.Windows.Forms.TextBox();
            this.ofd_open = new System.Windows.Forms.OpenFileDialog();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.chb_showPassword = new System.Windows.Forms.CheckBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.lbl_titlePassword = new System.Windows.Forms.Label();
            this.sfd_safeAt = new System.Windows.Forms.SaveFileDialog();
            this.ofd_textFiles = new System.Windows.Forms.OpenFileDialog();
            this.ftd_font = new System.Windows.Forms.FontDialog();
            this.cld_color = new System.Windows.Forms.ColorDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sts.SuspendLayout();
            this.tls.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts
            // 
            resources.ApplyResources(this.sts, "sts");
            this.sts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_status});
            this.sts.Name = "sts";
            this.sts.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            resources.ApplyResources(this.tssl_status, "tssl_status");
            // 
            // tls
            // 
            resources.ApplyResources(this.tls, "tls");
            this.tls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_open,
            this.tsb_save,
            this.tsb_saveAll,
            this.tsb_import,
            this.tsb_close,
            this.toolStripButton1,
            this.tsb_info});
            this.tls.Name = "tls";
            this.tls.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tsb_open
            // 
            resources.ApplyResources(this.tsb_open, "tsb_open");
            this.tsb_open.Name = "tsb_open";
            this.tsb_open.Click += new System.EventHandler(this.tsb_open_Click);
            // 
            // tsb_save
            // 
            resources.ApplyResources(this.tsb_save, "tsb_save");
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_saveAll
            // 
            resources.ApplyResources(this.tsb_saveAll, "tsb_saveAll");
            this.tsb_saveAll.Name = "tsb_saveAll";
            this.tsb_saveAll.Click += new System.EventHandler(this.tsb_saveAll_Click);
            // 
            // tsb_import
            // 
            resources.ApplyResources(this.tsb_import, "tsb_import");
            this.tsb_import.Name = "tsb_import";
            this.tsb_import.Click += new System.EventHandler(this.tsb_import_Click);
            // 
            // tsb_close
            // 
            resources.ApplyResources(this.tsb_close, "tsb_close");
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // tsb_info
            // 
            resources.ApplyResources(this.tsb_info, "tsb_info");
            this.tsb_info.Name = "tsb_info";
            this.tsb_info.Click += new System.EventHandler(this.tsb_info_Click);
            // 
            // txb_text
            // 
            this.txb_text.AcceptsTab = true;
            resources.ApplyResources(this.txb_text, "txb_text");
            this.txb_text.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txb_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_text.Name = "txb_text";
            this.txb_text.TextChanged += new System.EventHandler(this.txb_text_TextChanged);
            this.txb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_text_KeyDown);
            this.txb_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_text_KeyPress);
            // 
            // ofd_open
            // 
            resources.ApplyResources(this.ofd_open, "ofd_open");
            // 
            // pnl_password
            // 
            resources.ApplyResources(this.pnl_password, "pnl_password");
            this.pnl_password.Controls.Add(this.chb_showPassword);
            this.pnl_password.Controls.Add(this.txb_password);
            this.pnl_password.Controls.Add(this.lbl_titlePassword);
            this.pnl_password.Name = "pnl_password";
            // 
            // chb_showPassword
            // 
            resources.ApplyResources(this.chb_showPassword, "chb_showPassword");
            this.chb_showPassword.Name = "chb_showPassword";
            this.chb_showPassword.UseVisualStyleBackColor = true;
            this.chb_showPassword.CheckedChanged += new System.EventHandler(this.chb_showPassword_CheckedChanged);
            // 
            // txb_password
            // 
            resources.ApplyResources(this.txb_password, "txb_password");
            this.txb_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txb_password.Name = "txb_password";
            this.txb_password.UseSystemPasswordChar = true;
            this.txb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_password_KeyPress);
            // 
            // lbl_titlePassword
            // 
            resources.ApplyResources(this.lbl_titlePassword, "lbl_titlePassword");
            this.lbl_titlePassword.Name = "lbl_titlePassword";
            // 
            // sfd_safeAt
            // 
            resources.ApplyResources(this.sfd_safeAt, "sfd_safeAt");
            // 
            // ofd_textFiles
            // 
            resources.ApplyResources(this.ofd_textFiles, "ofd_textFiles");
            // 
            // cld_color
            // 
            this.cld_color.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.cld_color.FullOpen = true;
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pnl_password);
            this.Controls.Add(this.txb_text);
            this.Controls.Add(this.tls);
            this.Controls.Add(this.sts);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
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
        private System.Windows.Forms.FontDialog ftd_font;
        private System.Windows.Forms.ToolStripButton tsb_info;
        private System.Windows.Forms.ColorDialog cld_color;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

