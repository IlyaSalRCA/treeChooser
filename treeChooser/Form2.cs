using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeChooser
{
    public partial class Form2 : Form
    {
        private int treeTypeIndex = 0;

        public Form2(double pineResult, double firResult, double oakResult)
        {
            InitializeComponent();

            label1.Text = $"Древесина соответствует сосне на {pineResult}%";
            label2.Text = $"Древесина соответствует ели на {firResult}%";
            label3.Text = $"Древесина соответствует дубу на {oakResult}%";

            ChoosingTreeType(pineResult, firResult, oakResult);
        }

        void ChoosingTreeType(double pineResult, double firResult, double oakResult)
        {
            double[] trees = new double[] {pineResult, firResult, oakResult};

            Array.Sort(trees);

            if (trees[trees.Length - 1] > 80)
            {
                if(trees[trees.Length - 1] == pineResult)
                {
                    button1.Text = "Выбрать сосну";
                    treeTypeIndex = 1;

                }
                else if (trees[trees.Length - 1] == firResult)
                {
                    button1.Text = "Выбрать ель";
                    treeTypeIndex = 2;
                }
                else
                {
                    button1.Text = "Выбрать дуб";
                    treeTypeIndex = 3;
                }
            }
            else
            {
                button1.Width = 235;
                button1.Location = new Point(18, 141);
                button1.Text = "Ваше дерево не определено в программе";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(treeTypeIndex)
            {
                case 1:
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    this.Hide();
                    break;
                case 2:
                    this.Hide();

                    break;
                case 3:
                    this.Hide();

                    break;
                default:
                    button1.DialogResult = DialogResult.Cancel;
                    Hide();
                    break;
            }
        }
    }
}
