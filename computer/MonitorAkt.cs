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
    public partial class MonitorAkt : Form
    {
        public MonitorAkt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string warning = "";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                warning += "brand\n";
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                warning += "price\n";
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                warning += "diagonal\n";
            }
            if (!String.IsNullOrEmpty(warning))
            {
                MessageBox.Show("Complete the missing data: \n" + warning);
            }
            else {

                if (!TryParse(textBox2.Text))
                {
                    MessageBox.Show("Failed to convert the field: PRICE:\n");
                }
                
                else
                {
                    Form1.monitors.Add(new Monitor(textBox1.Text, float.Parse(textBox2.Text), textBox3.Text));
                    MessageBox.Show("Add object!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
        }
        bool TryParse(string taram)
        {
            try
            {
                if (float.Parse(taram) > 0)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool done = false;
            bool succesucceeded = false;
            if (Form1.monitors.Count() > 0)
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    if (!String.IsNullOrEmpty(textBox2.Text))
                    {
                        if (TryParse(textBox2.Text))
                        {
                            if (!String.IsNullOrEmpty(textBox3.Text)) //marka, cena i przekatna
                            {
                                for (int i = 0; i < Form1.monitors.Count; i++)
                                {
                                    if (Form1.monitors[i].Brand == textBox1.Text)
                                    {
                                        if (Form1.monitors[i].Price == float.Parse(textBox2.Text))
                                        {
                                            if (Form1.monitors[i].Diagonal == textBox3.Text)
                                            {
                                                Form1.monitors.Remove(Form1.monitors[i]);
                                                succesucceeded = true;
                                                break;
                                            }
                                        }

                                    }
                                }
                                done = true;
                            }
                            for (int i = 0; i < Form1.monitors.Count && !done; i++) //dla marka i cena
                            {
                                if (Form1.monitors[i].Brand == textBox1.Text)
                                {
                                    if (Form1.monitors[i].Price == float.Parse(textBox2.Text))
                                    {
                                        Form1.monitors.Remove(Form1.monitors[i]);
                                        succesucceeded = true;
                                        break;
                                    }
                                }
                            }
                            done = true;
                        }
                    }
                    if (!String.IsNullOrEmpty(textBox3.Text))
                    {
                        for (int i = 0; i < Form1.monitors.Count && !done; i++) // dla marka i przekatna
                        {
                            if (Form1.monitors[i].Brand == textBox1.Text)
                            {
                                if (Form1.monitors[i].Diagonal == textBox3.Text)
                                {
                                    Form1.monitors.Remove(Form1.monitors[i]);
                                    succesucceeded = true;
                                    break;
                                }
                            }
                        }
                        done = true;
                    }
                    for (int i = 0; i < Form1.monitors.Count && !done; i++) //tylko marka
                    {
                        if (Form1.monitors[i].Brand == textBox1.Text)
                        {
                            Form1.monitors.Remove(Form1.monitors[i]);
                            succesucceeded = true;
                            break;
                        }
                    }
                    done = true;

                }
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    if (TryParse(textBox2.Text))
                    {
                        if (!String.IsNullOrEmpty(textBox3.Text))
                        {
                            for (int i = 0; i < Form1.monitors.Count && !done; i++) //dla ceny i przekatnej
                            {
                                if (Form1.monitors[i].Price == float.Parse(textBox2.Text))
                                {
                                    if (Form1.monitors[i].Diagonal == textBox3.Text)
                                    {
                                        Form1.monitors.Remove(Form1.monitors[i]);
                                        succesucceeded = true;
                                        break;
                                    }
                                }
                            }
                            done = true;

                        }
                        for (int i = 0; i < Form1.monitors.Count && !done; i++) // tylko dla ceny
                        {
                            if (Form1.monitors[i].Price == float.Parse(textBox2.Text))
                            {
                                Form1.monitors.Remove(Form1.monitors[i]);
                                succesucceeded = true;
                                break;
                            }
                        }
                        done = true;
                    }

                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {
                    for (int i = 0; i < Form1.monitors.Count && !done; i++) // tylko dla przekatnej
                    {
                        if (Form1.monitors[i].Diagonal == textBox3.Text)
                        {
                            Form1.monitors.Remove(Form1.monitors[i]);
                            succesucceeded = true;
                            break;
                        }
                    }
                    done = true;
                }
                if (succesucceeded)
                {
                    MessageBox.Show("Item deleted!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Item not found, please try again!");
                }
            }
            else
            {
                MessageBox.Show("The list is empty!");
            }
        }
        

    }
}
