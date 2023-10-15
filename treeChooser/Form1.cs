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
        internal const double treeScore = 5;
        internal double pineScore;
        internal double pineResult;

        public Form1()
        {
            InitializeComponent();
            Pine.AddTree();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CheckTrees();
            pineResult = pineScore / treeScore * 100;
            Form2 form2 = new Form2(pineResult);
            form2.ShowDialog();
            pineScore = 0;
        }

        void CheckTrees()
        {
            if (checkBox1.Checked == Pine.TreeCore)
                pineScore++;
            if (comboBox1.Text == Pine.CoreColor)
                pineScore++;
            if (checkBox2.Checked == Pine.TreeResin)
                pineScore++;
            if (comboBox2.Text == Pine.TreeMedullary)
                pineScore++;
            if (comboBox3.Text == Pine.TreeDensity)
                pineScore++;
        }
    }
}
