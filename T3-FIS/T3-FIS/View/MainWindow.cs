using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_FIS.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AdaugareComanda adaugare = new AdaugareComanda();
            adaugare.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdaugareGarantie adaugare = new AdaugareGarantie();
            adaugare.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdaugareProdus adaugare = new AdaugareProdus();
            adaugare.Show();
        }
    }
}
