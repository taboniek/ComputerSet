using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitors
{
    public partial class KomputerForm : Form
    {
        public KomputerForm()
        {
            InitializeComponent();
            
            for(int i=0; i<Form1.procesors.Count(); i++)
            {
                comboBox1.Items.Add(Form1.procesors[i].ProcessorP);
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.procesors.Count(); i++) {
                if (Form1.procesors[i].ProcessorP == comboBox1.Text) {
                    textBox1.Text = Convert.ToString(Form1.procesors[i].PriceP);
                    }
            }
        }

        bool Sprawdzanko(string tak)
        {
            try
            {
                float.Parse(tak);
            }
            catch
            {
                return false;
            }
            return true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float dodaj;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (Sprawdzanko(textBox1.Text))
                {
                    if (float.Parse(textBox1.Text) < 0)
                    {
                        MessageBox.Show("Cena musi być większa od 0!");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(textBox2.Text))
                        {
                            textBox3.Text = textBox1.Text;
                        }
                        else
                        {
                            dodaj = float.Parse(textBox1.Text)+ float.Parse(textBox2.Text);
                            textBox3.Text = dodaj.ToString();
                        }
                    }
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float dodaj;
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                if (Sprawdzanko(textBox2.Text))
                {
                    if (float.Parse(textBox2.Text) < 0)
                    {
                        MessageBox.Show("Cena musi być większa od 0!");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(textBox1.Text))
                        {
                            textBox3.Text = textBox2.Text;
                        }
                        else
                        {
                            dodaj = float.Parse(textBox1.Text) + float.Parse(textBox2.Text);
                            textBox3.Text = dodaj.ToString();
                        }
                    }
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0; i<Form1.dysks.Count(); i++)
            {
                if(radioButton1.Text == Form1.dysks[i].Name)
                {
                    textBox2.Text = Form1.dysks[i].PriceD.ToString();
                }
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.dysks.Count(); i++)
            {
                if (radioButton2.Text == Form1.dysks[i].Name)
                {
                    textBox2.Text = Form1.dysks[i].PriceD.ToString();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.dysks.Count(); i++)
            {
                if (radioButton3.Text == Form1.dysks[i].Name)
                {
                    textBox2.Text = Form1.dysks[i].PriceD.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                try
                {
                    Form1.suma1 = float.Parse(textBox3.Text);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Wybierz procesor albo wybierz opcję anuluj!");
                }
            }
            else
            {
                MessageBox.Show("Wybierz dysk!");
            }
        }
    }
}
