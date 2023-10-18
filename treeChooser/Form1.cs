using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeChooser
{
    public partial class Form1 : Form
    {
        internal const double treeScore = 6;
        internal double pineScore;
        internal double pineResult;
        internal double firScore;
        internal double firResult;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            label2.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CheckTrees();
            pineResult = Math.Round(pineScore / treeScore * 100, 2);
            firResult = Math.Round(firScore / treeScore * 100, 2);
            Form2 form2 = new Form2(pineResult, firResult);
            form2.ShowDialog();
            pineScore = 0;
        }

        void CheckTrees()
        {
            if (comboBox4.Text == Pine.TreeColor)
                pineScore++;
            else if (comboBox4.Text == Fir.TreeColor)
                firScore++;

            if (checkBox1.Checked == Pine.TreeCore)
                pineScore++;
            else if(checkBox1.Checked == Fir.TreeCore)
                firScore++;

            if (comboBox1.Text == Pine.CoreColor)
                pineScore++;
            else if (comboBox1.Text == Fir.CoreColor)
                firScore++;

            if (checkBox2.Checked == Pine.TreeResin)
                pineScore++;
            else if (checkBox2.Checked == Fir.TreeResin)
                firScore++;

            if (comboBox2.Text == Pine.TreeMedullary)
                pineScore++;
            else if (comboBox2.Text == Fir.TreeMedullary)
                firScore++;

            if (comboBox3.Text == Pine.TreeDensity)
                pineScore++;
            else if (comboBox3.Text == Fir.TreeDensity)
                firScore++;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                comboBox1.SelectedIndex = 2;
                comboBox1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                comboBox1.Visible = true;
                label2.Visible = true;
            }
        }
    }
}
