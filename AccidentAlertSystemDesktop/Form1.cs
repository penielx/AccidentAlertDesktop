using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccidentAlertSystemDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Dashboard dsBorad = new Dashboard();
            dsBorad.Dock = DockStyle.Fill;
            dsBorad.Show();
            ContainerPanel.Controls.Add(dsBorad);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Devicealerts dvAlert = new Devicealerts();
            dvAlert.Dock = DockStyle.Fill;
            dvAlert.Show();
            ContainerPanel.Controls.Add(dvAlert);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Map mp = new Map();
            mp.Dock = DockStyle.Fill;
            mp.Show();
            ContainerPanel.Controls.Add(mp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            MobilePhones mp = new MobilePhones();
            mp.Dock = DockStyle.Fill;
            mp.Show();
            ContainerPanel.Controls.Add(mp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Reports mp = new Reports();
            mp.Dock = DockStyle.Fill;
            mp.Show();
            ContainerPanel.Controls.Add(mp);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Aboutus mp = new Aboutus();
            mp.Dock = DockStyle.Fill;
            mp.Show();
            ContainerPanel.Controls.Add(mp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            panel1.Visible = true;
            Dashboard dsBorad = new Dashboard();
            dsBorad.Dock = DockStyle.Fill;
            dsBorad.Show();
            ContainerPanel.Controls.Add(dsBorad);
        }
    }
}
