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
        public Form2(double pineResult)
        {
            InitializeComponent();
            label1.Text = $"Древесина соответствует сосне на {pineResult}%";
        }
    }
}
