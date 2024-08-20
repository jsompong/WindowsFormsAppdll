using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculatedll;

namespace WindowsFormsAppdll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate cal = new Calculate();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Add(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SUBbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Sub(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MULbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i
                int i = cal.Mul(int.Parse(txtFirstNo.Text), int.Parse(txtSecNo.Text));
                txtResult.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
