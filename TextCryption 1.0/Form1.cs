using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;

namespace TextCryption_1._0
{
    public partial class Form1 : Form
    {
        byte[] fileEnc = null;
        string fileDec = "";
        bool fileLoaded = false;
        string password = "";
        string savePath = "";
        string mode = "load";
        bool blocksound = false;
        string lang = "de";

        public Form1()
        {
            InitializeComponent();
            ftd_font.Font = txb_text.Font;

            if (!CultureInfo.CurrentCulture.Name.Contains("de"))
                lang = "en";

            if(Program.Arguments.Length > 0)
            {
                if(Path.GetExtension(Program.Arguments[0]) == ".enct")
                {
                    ofd_open.FileName = Program.Arguments[0];
                    tsb_open_Click(null, null);
                }
                else
                {
                    ofd_textFiles.FileName = Program.Arguments[0];
                    tsb_import_Click(null, null);
                }
            }
        }

        private void tsb_open_Click(object sender, EventArgs e)
        {
            mode = "load";

            if (ofd_open.ShowDialog() != DialogResult.OK)
                return;

            tls.Enabled = false;
            pnl_password.Visible = true;

            if(lang == "de")
                tssl_status.Text = "Passwort eingeben und mit ENTER bestätigen";
            else
                tssl_status.Text = "Enter password and confirm with ENTER";
        }

        private void chb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txb_password.UseSystemPasswordChar = !chb_showPassword.Checked;
        }

        string Decrypt(byte[] enc, string pw_)
        {
            try
            {
                byte[] pw = Encoding.Default.GetBytes(pw_);
                RijndaelManaged rm = new RijndaelManaged();
                MemoryStream ms = new MemoryStream();
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(pw, pw);
                CryptoStream cs = new CryptoStream(ms, rm.CreateDecryptor(pdb.GetBytes(32), pdb.GetBytes(16)), CryptoStreamMode.Write);
                cs.Write(enc, 0, enc.Length);
                cs.FlushFinalBlock();
                cs.Close();
                return Encoding.Default.GetString(ms.ToArray());
            }
            catch
            {
                if(lang == "de")
                    MessageBox.Show("Das angegebene Passwort ist falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("The given password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "|||||PW-ERROR|||||";
            }
        }

        byte[] Encrypt(string dec, string pw_)
        {
            byte[] text = Encoding.Default.GetBytes(dec);
            byte[] pw = Encoding.Default.GetBytes(pw_);
            RijndaelManaged rm = new RijndaelManaged();
            MemoryStream ms = new MemoryStream();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(pw, pw);
            CryptoStream cs = new CryptoStream(ms, rm.CreateEncryptor(pdb.GetBytes(32), pdb.GetBytes(16)), CryptoStreamMode.Write);
            cs.Write(text, 0, text.Length);
            cs.FlushFinalBlock();
            cs.Close(); 
            return ms.ToArray();
        }

        private void txb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            e.Handled = true;

            if(mode == "load")
            {
                if (txb_password.Text.Length > 3)
                {
                    password = txb_password.Text;
                    txb_password.Text = "";
                    chb_showPassword.Checked = false;

                    fileEnc = File.ReadAllBytes(ofd_open.FileName);
                    fileDec = Decrypt(fileEnc, password);

                    pnl_password.Visible = false;
                    tls.Enabled = true;
                    if (fileDec == "|||||PW-ERROR|||||")
                    {
                        if(lang == "de")
                            tssl_status.Text = "Falsches Passwort bei Datei: " + Path.GetFileName(ofd_open.FileName);
                        else
                            tssl_status.Text = "Wrong password for file: " + Path.GetFileName(ofd_open.FileName);
                        return;
                    }

                    fileLoaded = true;
                    savePath = ofd_open.FileName;
                    txb_text.Text = fileDec;

                    if(lang == "de")
                        tssl_status.Text = "Datei \"" + Path.GetFileName(savePath) + "\" wurde erfolgreich geladen";
                    else
                        tssl_status.Text = "File \"" + Path.GetFileName(savePath) + "\" was loaded successfully";
                }
                else
                {
                    if(lang == "de")
                        MessageBox.Show("Das Passwort muss länger als 4 Zeichen sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("The password must be longer than 4 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(mode == "save")
            {
                if (txb_password.Text.Length > 3)
                {
                    password = txb_password.Text;
                    txb_password.Text = "";
                    chb_showPassword.Checked = false;

                    fileDec = txb_text.Text;
                    fileEnc = Encrypt(fileDec, password);

                    pnl_password.Visible = false;
                    tls.Enabled = true;

                    fileLoaded = true;
                    savePath = sfd_safeAt.FileName;
                    File.WriteAllBytes(savePath, fileEnc);

                    if(lang == "de")
                        tssl_status.Text = "Datei \"" + Path.GetFileName(savePath) + "\" wurde erfolgreich gespeichert";
                    else
                        tssl_status.Text = "File \"" + Path.GetFileName(savePath) + "\" was saved successfully";
                }
                else
                {
                    if (lang == "de")
                        MessageBox.Show("Das Passwort muss länger als 4 Zeichen sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("The password must be longer than 4 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mode = "load";
            }
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            if (fileLoaded)
            {
                File.WriteAllBytes(savePath, Encrypt(txb_text.Text, password));

                if(lang == "de")
                    tssl_status.Text = "Datei \"" + Path.GetFileName(savePath) + "\" erfolgreich gespeichert";
                else
                    tssl_status.Text = "File \"" + Path.GetFileName(savePath) + "\" saved successfully";
            }
            else
            {
                tsb_saveAll_Click(sender, e);
            }
        }

        private void tsb_saveAll_Click(object sender, EventArgs e)
        {
            mode = "save";
            if (sfd_safeAt.ShowDialog() != DialogResult.OK)
                return;

            pnl_password.Visible = true;
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            if(lang == "de")
                if(tssl_status.Text.Contains("  *"))
                    if (MessageBox.Show("Soll die Datei wirklich geschlossen werden?", "Schließen", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
            if(lang == "en")
                if (tssl_status.Text.Contains("  *"))
                    if (MessageBox.Show("Are you sure you want to close the file?", "Close", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

            byte[] fileEnc = null;
            string fileDec = "";
            bool fileLoaded = false;
            string password = "";
            string savePath = "";
            txb_text.Text = "";
            if(lang == "de")
                tssl_status.Text = "Keine Datei geöffnet";
            else
                tssl_status.Text = "No file opened";
        }

        private void tsb_import_Click(object sender, EventArgs e)
        {
            if (ofd_textFiles.ShowDialog() != DialogResult.OK)
                return;

            sfd_safeAt.FileName = Path.GetDirectoryName(ofd_textFiles.FileName) + "\\" + Path.GetFileNameWithoutExtension(ofd_textFiles.FileName) + ".enct";
            txb_text.Text = File.ReadAllText(ofd_textFiles.FileName);
            string fileDec = txb_text.Text;

            tsb_saveAll_Click(sender, e);
        }

        private void txb_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                blocksound = true;
            if (e.KeyData == (Keys.Control | Keys.S))
                tsb_save_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.Shift | Keys.S))
                tsb_saveAll_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.O))
                tsb_open_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.I))
                tsb_import_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.F4))
                tsb_close_Click(null, null);

        }

        private void txb_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blocksound)
                e.Handled = true;
            blocksound = false;
        }

        private void tsb_font_Click(object sender, EventArgs e)
        {
            if (ftd_font.ShowDialog() != DialogResult.OK)
                return;

            txb_text.Font = ftd_font.Font;
        }

        private void txb_text_TextChanged(object sender, EventArgs e)
        {
            if(!tssl_status.Text.Contains("  *"))
                tssl_status.Text += "  *";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tssl_status.Text.Contains("  *") & fileLoaded)
            {
                DialogResult dr;

                if(lang == "de")
                    dr= MessageBox.Show("Es gibt ungespeicherte Änderungen...\nSoll die geöffnete Datei gespeichert werden?", "Schließen", MessageBoxButtons.YesNoCancel);
                else
                    dr = MessageBox.Show("There are unsaved changes... \nDo you want to save the open file? ", "Close", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    tsb_save_Click(null, null);
                    Close();
                }
                else if(dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
