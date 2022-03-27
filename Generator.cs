using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AHAHAH_Generator
{
    public partial class Generator : Form
    {
        #region stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Generator()
        {
            InitializeComponent();
        }

        private void Generator_Load(object sender, EventArgs e)
        {

        }
        private void Generator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        private static Random RandomStrings = new Random();
        public static string UpperCase(int length)
        {
            const string chars = "AHAHAHAHAHAHAHAHAHAHAHAAHAHAHAHAHAHAHAHAHAHAHAHAHAHAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHAHAHAHAHHAAHAHAHAHHHAAHAHAHAHAHHAHAHAHAAHAAHAHAHAAHHAHAAAHHAHAHHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHAHAHAHAHHAAHAHAHAHHHAAHAHAHAHAHHAHAHAHAAHAAHAHAHAAHHAHAAAHHAHAHAHAHAHHAHAHAHAHAHAHAHAHAHHAHHAHA";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomStrings.Next(s.Length)]).ToArray());
        }
        public static string LowerCase(int length)
        {
            const string chars = "aaaaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhahahhahahahhahhahahhahaahahaaaaaaaahhhhhhhhahahahahahaahahahhaahahahahahahahhaaaaaaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhhhhhhhhhhhhhhhhhhaaaaaaaaaahahahahahaahhahahhahahahahaahhaahahahhahahahahahahahaahhahahahaaaaaaaaaaaaahahahahahhahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhaaaaaaaaaaaaaaaaaaaaaaaaaaaahhhhhhhhhhhaahahahahaa";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomStrings.Next(s.Length)]).ToArray());
        }
        public static string Mix(int length)
        {
            const string chars = "AAAAAAAAAAAAAAAAHHHHHHHHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHAHAHHAHAHHAAHAHHAHAHAAHAHHAHHaaaaaaaaaaaaaaaahhhhhhhhhhhhhhhhhhhhhahhahaahahaaaaaaaahhhhhhhhahahahahahaahahahhaahahahahahahahhaaaaaaaaaaahhhhhhhhhhhhhhhaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaahahahahahahAHAHAHAHAHAHAHAHAAAAAAAAAAHhhhhhhhhhhhhhAAAAAAAHhhhhHHHHHHHHHAAAAAHHHHahaahahaha";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomStrings.Next(s.Length)]).ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!upper.Checked && !lower.Checked && !mix.Checked)
            {
                MessageBox.Show("Please select a valid method", "AHAHAH_Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (upper.Checked)
                {
                    copyclip.Text = "";
                    try
                    {
                        int number = int.Parse(charslenght.Text);
                        generatedtext.Text = UpperCase(number);
                        Clipboard.SetText(generatedtext.Text);
                        copyclip.Text = "Succesfully copied your generated\ntext in your clipboard.";
                    }
                    catch
                    {
                        MessageBox.Show($"{charslenght.Text} is not a valid number.\nPlease choose a valid number.", "AHAHAH_Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (lower.Checked)
                {
                    copyclip.Text = "";
                    try
                    {
                        int number = int.Parse(charslenght.Text);
                        generatedtext.Text = LowerCase(number);
                        Clipboard.SetText(generatedtext.Text);
                        copyclip.Text = "Succesfully copied your generated\ntext in your clipboard.";
                    }
                    catch
                    {
                        MessageBox.Show($"{charslenght.Text} is not a valid number.\nPlease choose a valid number.", "AHAHAH_Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (mix.Checked)
                {
                    copyclip.Text = "";
                    try
                    {
                        int number = int.Parse(charslenght.Text);
                        generatedtext.Text = Mix(number);
                        Clipboard.SetText(generatedtext.Text);
                        copyclip.Text = "Succesfully copied your generated\ntext in your clipboard.";
                    }
                    catch
                    {
                        MessageBox.Show($"{charslenght.Text} is not a valid number.\nPlease choose a valid number.", "AHAHAH_Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/cabboshiba");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/cabboshiba");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.com/users/921400561205661706/");
        }
    }
}
