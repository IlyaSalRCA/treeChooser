using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeChooser
{
    public partial class Form3 : Form
    {
        int treeTypeIndex;
        public Form3(int treeTypeIndex) //1 - сосна, 2 - ель, 3 - дуб
        {
            InitializeComponent();

            this.treeTypeIndex = treeTypeIndex;

            switch (treeTypeIndex)
            {
                case 1:
                    Pine.AddTree();
                    break;
                case 2:
                    Fir.AddTree();
                    break;
                case 3:
                    Oak.AddTree();
                    break;
                default:
                    break;
            }

            comboBox4.SelectedIndex = 1;
            comboBox5.SelectedIndex = 1;
            comboBox2.SelectedIndex = 2;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label6.Visible = false;
                label7.Visible = false;

                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
            }
            else
            {
                label6.Visible = true;
                label7.Visible = true;

                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Шлифование
            if(comboBox3.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
            {
                comboBox4.Visible = true;
                label4.Visible = true;
            }
            else
            {
                comboBox4.Visible = false;
                label4.Visible = false;
            }

            if (comboBox3.SelectedIndex == 0 && comboBox1.SelectedIndex == 1)
            {
                checkBox1.Visible = true;
                label5.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                label5.Visible = false;
            }

            //Строгание
            if (comboBox3.SelectedIndex == 1 && treeTypeIndex != 3)
            {
                comboBox2.Visible = true;
                label2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label2.Visible = false;
            }

            if (comboBox3.SelectedIndex == 1 && treeTypeIndex == 3)
            {
                comboBox5.Visible = true;
                label8.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
                label8.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Шлифование
            if (comboBox3.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
            {
                comboBox4.Visible = true;
                label4.Visible = true;
            }
            else
            {
                comboBox4.Visible = false;
                label4.Visible = false;
            }

            if (comboBox3.SelectedIndex == 0 && comboBox1.SelectedIndex == 1)
            {
                checkBox1.Visible = true;
                label5.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                label5.Visible = false;
            }
        }

        private bool WidthDepthPlates(int width, int depth)
        {
            if (width >= 100 && depth >= 100)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == -1)
                comboBox3.SelectedIndex = 0;
            if (comboBox1.SelectedIndex == -1)
                comboBox1.SelectedIndex = 0;
        }
    }
}
