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
    public partial class Form2 : Form
    {
        public Form2(double pineResult, double firResult, double oakResult)
        {
            InitializeComponent();

            label1.Text = $"Древесина соответствует сосне на {pineResult}%";
            label2.Text = $"Древесина соответствует ели на {firResult}%";
            label3.Text = $"Древесина соответствует дубу на {oakResult}%";
        }
    }
}
