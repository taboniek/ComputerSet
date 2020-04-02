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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
            for(int i =0; i<Form1.monitors.Count(); i++)
            {
                var row = new string[] { Form1.monitors[i].Brand};
                var tidi = new ListViewItem(row);
                tidi.Tag = Form1.monitors[i];

                listView1.Items.Add(tidi);
            }
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var wybranyItem = (Monitor)listView1.SelectedItems[0].Tag;
                for(int i=0; i<Form1.monitors.Count(); i++)
                {
                    if(wybranyItem.Brand == Form1.monitors[i].Brand)
                    {
                        textBox1.Text = Form1.monitors[i].Price.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Error 503");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.suma2 = float.Parse(textBox1.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Choose options or choose cancel!");
            }
        }
    }
}
