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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Pine.AddTree();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Pine.pines[0].treeType;
        }
    }
}
