using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCryption_1._0
{
    static class Program
    {
        public static string[] Arguments;
        public static Font font;
        public static Color BackColor;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            Arguments = Args;

            try
            {
                using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\color.bin")))
                {
                    BackColor = ((NewColor)new BinaryFormatter().Deserialize(ms)).Color;
                }

                using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\font.bin")))
                {
                    font = ((NewFont)new BinaryFormatter().Deserialize(ms)).Font;
                }
            }
            catch
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\");

                using (MemoryStream ms = new MemoryStream())
                {
                    new BinaryFormatter().Serialize(ms, new NewColor(SystemColors.ControlDarkDark));
                    File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\color.bin", ms.ToArray());
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    new BinaryFormatter().Serialize(ms, new NewFont(new Font("Segoe UI", 12f, FontStyle.Regular)));
                    File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TextCryption\font.bin", ms.ToArray());
                }

                BackColor = SystemColors.ControlDarkDark;
                font = new Font("Segoe UI", 12f, FontStyle.Regular);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
