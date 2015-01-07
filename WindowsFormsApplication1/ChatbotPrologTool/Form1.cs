using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string x, y, z,a;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PrologConverter();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            textBox1.Focus();

        }

        public void PrologConverter()
        {
            richTextBox1.Text = richTextBox1.Text + "\n \n category([\n" + x + "\n" + y + "\n" + z + "\n ]).";
        }

        public string checkCapital(string text)
        {
            char[] marks = {'.'};
            string test = "'";
            //if (string.IsNullOrWhiteSpace(text))
             //  return "";
            StringBuilder newText = new StringBuilder(text.Length * 2);
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)

            {
                if (i < words.Length - 1)
                {
                    if ((words[i].Any(char.IsUpper) || words[i].Any(char.IsPunctuation)) && !words[i].Contains("star("))
                    {
                        newText.Append(test + words[i] + test + ",");
                    }
                    else
                    {
                        newText.Append(words[i] + ",");
                    }
                }
                else
                    if ((words[i].Any(char.IsUpper) || words[i].Any(char.IsPunctuation)) && !words[i].Contains("star("))
                    {
                        newText.Append(test + words[i] + test);
                    }
                    else
                    {
                        newText.Append(words[i]);
                    }
            }
            
            return newText.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = "\t pattern([ " + checkCapital(textBox1.Text) + "]),";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y = "\t \t that([" + checkCapital(textBox2.Text) + "]),";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            z = "\t \t template([" + checkCapital(textBox3.Text) + "])";
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                button1.PerformClick();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                button1.PerformClick();
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                button1.PerformClick();
            }
        }
        
    }
}
