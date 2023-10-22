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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace treeChooser
{
    public partial class Form1 : Form
    {
        internal const double treeScore = 6;

        internal double pineScore;
        internal double pineResult;

        internal double firScore;
        internal double firResult;

        internal double oakScore;
        internal double oakResult;

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
            oakResult = Math.Round(oakScore / treeScore * 100, 2);

            Form2 form2 = new Form2(pineResult, firResult, oakResult);
            
            this.Hide();

            if(form2.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                form2.Dispose();
            }

            pineScore = 0;
            firScore = 0;
            oakScore = 0;
        }

        void CheckTrees()
        {
            //Цвет древесины
            switch (comboBox4.Text)
            {
                case Pine.TreeColor:
                    pineScore++;
                    break;
                case Fir.TreeColor:
                    firScore++;
                    break;
                case Oak.TreeColor:
                    oakScore++;
                    break;
                default:
                    break;
            }
            //Наличие ядра
            switch (checkBox1.Checked)
            {
                case true:
                    pineScore++;
                    oakScore++;
                    break;
                case false:
                    firScore++;
                    break;
                default:
                    break;
            }
            //Цвет ядра
            switch (comboBox1.Text)
            {
                case Pine.CoreColor:
                    pineScore++;
                    break;
                case Fir.CoreColor:
                    firScore++;
                    break;
                case Oak.CoreColor:
                    oakScore++;
                    break;
                default:
                    break;
            }
            //Наличие смоляных ходов
            switch (checkBox2.Checked)
            {
                case true:
                    pineScore++;
                    break;
                case false:
                    firScore++;
                    oakScore++;
                    break;
                default:
                    break;
            }
            //Наличие сердцевинных лучей
            switch (comboBox2.Text)
            {
                case Pine.TreeMedullary:
                    pineScore++;
                    break;
                case Fir.TreeMedullary:
                    firScore++;
                    break;
                case Oak.TreeMedullary:
                    oakScore++;
                    break;
                default:
                    break;
            }
            //Степень плотности
            switch (comboBox3.Text)
            {
                case Pine.TreeDensity:
                    pineScore++;
                    break;
                case Fir.TreeDensity:
                    firScore++;
                    break;
                case Oak.TreeDensity:
                    oakScore++;
                    break;
                default:
                    break;
            }

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
