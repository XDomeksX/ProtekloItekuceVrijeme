using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtekloItekuceVrijeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime pocetno = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            timer.Enabled = true;
            timer.Start();
            string time = DateTime.Now.ToString("h:mm:ss tt");
            toolStripStatusLabel1.Text = "Trenutno: " + time;
            toolStripStatusLabel2.Text = "Proteklo: " + proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}
