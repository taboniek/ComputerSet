using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace monitors
{
    public partial class Form1 : Form
    {
        public static List<Processor> procesors = new List<Processor>();
        public static List<Monitor> monitors = new List<Monitor>();
        public static List<Disc> dysks = new List<Disc>();
        public static float suma1 =0;
        public static float suma2 = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            cenaBox.ReadOnly = true;

            try
            {
                XDocument xml = XDocument.Load("Procesory.xml");
                procesors = (
                    from procesor in xml.Root.Elements("procesor")
                    select new Processor(
                        procesor.Element("ProcesorP").Value,
                        float.Parse(procesor.Element("CenaP").Value))).ToList<Processor>();
            }
            catch{ }
            try
            {
                XDocument xml = XDocument.Load("Monitory.xml");
                monitors = (
                    from monitor in xml.Root.Elements("monitor")
                    select new Monitor(
                        monitor.Element("Marka").Value,
                        float.Parse(monitor.Element("Cena").Value),
                        monitor.Element("Przekatna").Value)).ToList<Monitor>();

            }
            catch { }
            try {
                XDocument xml = XDocument.Load("Dyski.xml");
                dysks = (
                    from dysk in xml.Root.Elements("dysk")
                    select new Disc(
                        dysk.Element("Nazwa").Value,
                        float.Parse(dysk.Element("CenaD").Value))).ToList<Disc>();
                        
            }
            catch(Exception ex) {
               
            }
        }

        private void procesor_Click(object sender, EventArgs e)
        {
            ProcesorForm procesorForm = new ProcesorForm();
            procesorForm.Show();
        }

        private void monitorAk_Click(object sender, EventArgs e)
        {
            MonitorAkt monitorAkt = new MonitorAkt();
            monitorAkt.Show();
        }

        private void komputer_Click(object sender, EventArgs e)
        {
            KomputerForm komputerForm = new KomputerForm();
            komputerForm.Show();
        }

        private void monitor_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(suma1 >0 && suma2 > 0)
            {
                cenaBox.BackColor = Color.Green;
            }
            else if (suma1 >0 || suma2 > 0)
            {
                cenaBox.BackColor = Color.Yellow;
            }
            cenaBox.Text = (suma1 + suma2).ToString();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Lista monitorów"),
                new XElement("monitors",
                from monitor in monitors
                select new XElement("monitor",
                new XElement("Marka", monitor.Brand),
                new XElement("Cena", monitor.Price.ToString()),
                new XElement("Przekatna", monitor.Diagonal)
                )));
            xml.Save("Monitory.xml");

            XDocument xml2 = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Lista procesorów"),
                new XElement("procesor",
                from procesor in procesors
                select new XElement("procesor",
                new XElement("ProcesorP", procesor.ProcessorP),
                new XElement("CenaP", procesor.PriceP.ToString())
                )));
            xml2.Save("Procesory.xml");

            XDocument xml3 = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Lista dysków"),
                new XElement("dysk",
                from dysk in dysks
                select new XElement("dysk",
                new XElement("Nazwa", dysk.Name),
                new XElement("CenaD", dysk.PriceD.ToString())
                )));
            xml3.Save("Dyski.xml");


        }
        


    }
}
