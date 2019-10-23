using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6_Kyselov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sname = textBox2.Text;
            string mail = textBox3.Text;
            string pass = textBox4.Text;
            if (!((name == "") | (sname == "") | (mail == "") | (pass == "")))
            {
                string nick = mail.Substring(0, mail.IndexOf('@'));

                if (pass.Length < 6)
                {
                    MessageBox.Show("The password inckude very few letters");
                }
                char[] c = pass.ToCharArray();
                string sym = "._";
                foreach (char lu in c)
                {
                    if (!((char.IsLetter(lu) | char.IsNumber(lu) | sym.Contains(lu))))
                    {
                        MessageBox.Show("Incorrect symbol");
                    }
                }
                if ( pass == nick)
                {
                    MessageBox.Show("Login and password are the same");
                }
                int nn = 0;
                foreach (char lu in c)
                {
                    if (char.IsNumber(lu))
                    {
                        nn++;
                    }
                }
                if (nn < 1)
                {
                    MessageBox.Show("Digits are absent");
                }
                else
                {
                    textBox5.Text = name + " " + sname + " - You are registered with the name " + nick;
                }
            }
            else
            {
                MessageBox.Show("You must fill all positions");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
