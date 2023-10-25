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
        string treeHumidity = "";
        string treeType = "";
        string treeProcessing = "";
        string treeProcessingSecond = "";
        string lumberType = "";

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
                comboBox4.SelectedIndex = 1;
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
                checkBox1.Checked = false;
            }

            //Строгание и прочее
            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && treeTypeIndex != 3)
            {
                comboBox2.Visible = true;
                label2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label2.Visible = false;
                comboBox2.SelectedIndex = 2;
            }

            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && treeTypeIndex == 3)
            {
                comboBox5.Visible = true;
                label8.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
                label8.Visible = false;
                comboBox5.SelectedIndex = 1;
            }

            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && comboBox1.SelectedIndex == 1)
            {
                checkBox1.Visible = true;
                label5.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                label5.Visible = false;
                checkBox1.Checked = false;
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
                comboBox4.SelectedIndex = 1;
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
                checkBox1.Checked = false;
            }

            //Строгание и прочее
            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && treeTypeIndex != 3)
            {
                comboBox2.Visible = true;
                label2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label2.Visible = false;
                comboBox2.SelectedIndex = 2;
            }

            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && treeTypeIndex == 3)
            {
                comboBox5.Visible = true;
                label8.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
                label8.Visible = false;
                comboBox5.SelectedIndex = 1;
            }

            if ((comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2) && comboBox1.SelectedIndex == 1)
            {
                checkBox1.Visible = true;
                label5.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                label5.Visible = false;
                checkBox1.Checked = false;
            }
        }

        private bool WidthDepthPlates(decimal width, decimal depth)
        {
            if (width >= 100 && depth >= 100)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomenclatureCode = "";

            if (comboBox3.SelectedIndex == -1)
                comboBox3.SelectedIndex = 0;
            if (comboBox1.SelectedIndex == -1)
                comboBox1.SelectedIndex = 0;
            if (comboBox5.SelectedIndex == 0 && treeTypeIndex == 3)
                comboBox1.SelectedIndex = 2;

            TakingText(); //Получение текста из полей

            //Создание экземпляра дерева
            switch (treeTypeIndex)
            {
                case 1:
                    Pine pine_test = new Pine(treeHumidity, treeType, treeProcessing,treeProcessingSecond, 
                        checkBox1.Checked, WidthDepthPlates(numericUpDown1.Value, numericUpDown2.Value), "");
                    nomenclatureCode = Pine.CheckNomenclatureCose(pine_test);
                    break;
                case 2:
                    Fir fir_test = new Fir(treeHumidity, treeType, treeProcessing, treeProcessingSecond,
                        checkBox1.Checked, WidthDepthPlates(numericUpDown1.Value, numericUpDown2.Value), "");
                    nomenclatureCode = Fir.CheckNomenclatureCose(fir_test);
                    break;
                case 3:
                    Oak oak_test = new Oak(treeHumidity, lumberType, treeProcessing, treeProcessingSecond,
                        checkBox1.Checked, WidthDepthPlates(numericUpDown1.Value, numericUpDown2.Value), "");
                    nomenclatureCode = Oak.CheckNomenclatureCose(oak_test);
                    break;
                default: 
                    break;
            }

            if (nomenclatureCode != "")
                label9.Text = $"Ваш код ТН ВЭД ЕАЭС: {nomenclatureCode}";
            else
                label9.Text = "Ошибка классификации";
        }

        private void TakingText()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    treeHumidity = "менее 22%";
                    break;
                case 1:
                    treeHumidity = "22% и более";
                    break;
                case 2:
                    treeHumidity = "-";
                    break;
                default:
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    treeType = "Pinus sylvestris L.";
                    break;
                case 1:
                    treeType = "Picea abies Karst.";
                    break;
                case 2:
                    treeType = "Иной";
                    break;
                default:
                    break;
            }
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    treeProcessing = "Шлифование или торцевое соединение";
                    break;
                case 1:
                    treeProcessing = "Строгание";
                    break;
                case 2:
                    treeProcessing = "Прочее";
                    break;
                default:
                    break;
            }
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    treeProcessingSecond = "Шлифование или строгание";
                    break;
                case 1:
                    treeProcessingSecond = "Прочее";
                    break;
                default:
                    break;
            }
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    lumberType = "Бруски, планки и фриз для паркета или деревянного покрытия полов,несобранные";
                    break;
                case 1:
                    lumberType = "Иной";
                    break;
                default:
                    break;
            }
        }
    }
}
