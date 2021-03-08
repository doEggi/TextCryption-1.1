using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCryption_1._0
{
    public partial class Settings : Form
    {
        string lang = "";

        public Settings(string language)
        {
            lang = language;
            InitializeComponent();

            pnl_showColor.BackColor = Program.BackColor;
            lbl_showFont.Font = Program.font;
            ftd_font.Font = lbl_showFont.Font;
            cld_color.Color = pnl_showColor.BackColor;
        }

        private void Settings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
                Close();
        }

        private void lbl_showFont_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
                ftd_font.Font = new Font("Segoe UI", 12f, FontStyle.Regular);
            else if (ftd_font.ShowDialog() != DialogResult.OK)
                return;


            lbl_showFont.Font = ftd_font.Font;
            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, new NewFont(lbl_showFont.Font));
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\font.bin", ms.ToArray());
            }

            Program.font = lbl_showFont.Font;
        }

        private void pnl_showColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cld_color.Color = SystemColors.ControlDarkDark;
            else if (cld_color.ShowDialog() != DialogResult.OK)
                return;


            if (cld_color.Color.GetBrightness() < 0.2f)
            {
                if (lang == "de")
                    MessageBox.Show("Sehr dunkle Farben sind auf Grund der Schrift nicht wählbar...", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Very dark colors are not avaiable, because you can't read your text anymore...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            pnl_showColor.BackColor = cld_color.Color;

            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, new NewColor(pnl_showColor.BackColor));
                File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\color.bin", ms.ToArray());
            }

            Program.BackColor = pnl_showColor.BackColor;
        }
    }

    [Serializable]
    public class NewFont
    {
        public Font Font { get; set; }

        public NewFont(Font f)
        {
            Font = f;
        }
    }

    [Serializable]
    public class NewColor
    {
        public Color Color { get; set; }

        public NewColor(Color c)
        {
            Color = c;
        }
    }
}
