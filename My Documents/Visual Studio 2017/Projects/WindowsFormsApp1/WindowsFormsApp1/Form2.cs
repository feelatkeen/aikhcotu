using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string oknoname;
            int naselenie;
            oknoname = "Государство: " + Form1.gosudarstvo;
            label1.Text = oknoname;
            naselenie = 2;
            label2.Text = "Население: " + naselenie;
            int razmergosva;
            razmergosva = 4000;
            label3.Text = "Территория: " + razmergosva;

        }
    }
}
