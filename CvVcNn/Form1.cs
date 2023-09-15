using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CvVcNn
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void seederbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[random.Next(128)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            seedBox.Text = new String(stringChars);
            resultBox1.Text = updatetext(inputBox1.Text);
        }
        static int seederc(string str)
        {
            if (String.IsNullOrEmpty(str))
            {


                Random random = new Random();
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[random.Next(128)];

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                return new String(stringChars).GetHashCode();
            }
            else
            {
                return str.GetHashCode();
            }
        }
        private void seedBox_TextChanged(object sender, EventArgs e)
        {

            seed = seederc(seedBox.Text);
            resultBox1.Text = updatetext(inputBox1.Text);
        }
        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            resultBox1.Text = updatetext(inputBox1.Text);
        }
        static int seed;
        //static Random rs = new Random();
        static string[] strings = { ";=A=;", ";=a=;", ";=C=;", ";=c=;", ";=V=;", ";=v=;", ";=N=;", ";=n=;", };
        static string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string a = "abcdefghijklmnopqrstuvwxyz";
        static string C = "BCDFGHJKLMNPQRSTVWXYZ";
        static string c = "bcdfghjklmnpqrstvwxyz";
        static string V = "AEIOU";
        static string v = "aeiou";
        static string N = "1234567890";

        static string updatetext(string inp)
        {
            var AR = A.ToCharArray();
            var ar = a.ToCharArray();
            var CR = C.ToCharArray();
            var cr = c.ToCharArray();
            var VR = V.ToCharArray();
            var vr = v.ToCharArray();
            var NR = N.ToCharArray();
            for (int i = 0; i < strings.Length; i++)
            {
                Random rs = new Random(seed);
                string pattern = strings[i];

                switch (i)
                {
                    case 0:
                        inp = Regex.Replace(inp, pattern, m => AR[rs.Next(AR.Length)].ToString());
                        break;
                    case 1:
                        inp = Regex.Replace(inp, pattern, m => ar[rs.Next(ar.Length)].ToString());
                        break;
                    case 2:
                        inp = Regex.Replace(inp, pattern, m => CR[rs.Next(CR.Length)].ToString());
                        break;
                    case 3:
                        inp = Regex.Replace(inp, pattern, m => cr[rs.Next(cr.Length)].ToString());
                        break;
                    case 4:
                        inp = Regex.Replace(inp, pattern, m => VR[rs.Next(VR.Length)].ToString());
                        break;
                    case 5:
                        inp = Regex.Replace(inp, pattern, m => vr[rs.Next(vr.Length)].ToString());
                        break;
                    case 6:
                        inp = Regex.Replace(inp, pattern, m => NR[rs.Next(NR.Length)].ToString());
                        break;
                    case 7:
                        inp = Regex.Replace(inp, pattern, m => NR[rs.Next(NR.Length)].ToString());
                        break;
                }
            }
            return inp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[1]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[2]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[3]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[4]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[5]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[6]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputBox1.Paste(strings[7]);
        }
    }
}
