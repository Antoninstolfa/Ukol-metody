﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_metody_v_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Goldenrod;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

            button3.ForeColor = Color.Goldenrod;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gold;
        }

        bool JePrvocislo(bool prvocislo,int vstup, int pocetDelitelu, int delitel)
        {
            prvocislo = false;
            while(delitel != vstup + 1)
            {
                if (vstup % delitel == 0)
                {
                    pocetDelitelu++;
                    if (pocetDelitelu <= 2)
                    {
                        prvocislo = true;

                    }
                    else
                    {
                        prvocislo = false;
                    }
                }
                delitel++;
            }
            return prvocislo;
        }

        void Prepis(TextBox textBox, ListBox listBox)
        {
            int pocetDelitelu = 0, delitel = 1;
            bool prvocislo = false;
            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                int vstup = Convert.ToInt32(textBox1.Lines[i]);
                if (JePrvocislo(prvocislo, vstup, pocetDelitelu, delitel))
                {
                    listBox1.Items.Add(vstup);
                }
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int pocetDelitelu = 0,delitel = 1;
            bool prvocislo = false;
            int vstup = (int)numericUpDown1.Value;
            odpoved.Text = String.Format("Tohle číslo {0} prvočíslo!", JePrvocislo(prvocislo,vstup,pocetDelitelu,delitel) ? "je" : "není");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown2.Value;
            Random rnd = new Random();


            textBox1.Text = string.Empty;
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                textBox1.Text += rnd.Next(2, 16);
                if (i < n - 1) textBox1.Text += Environment.NewLine;
            }



            Prepis(textBox1, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
