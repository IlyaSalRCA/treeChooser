using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeChooser
{
    internal class Pine : Tree
    {
        internal const bool TreeCore = true;
        internal const string CoreColor = "От розового до буровато-красного";
        internal const bool TreeResin = true;
        internal const string TreeMedullary = "Слабо заметны";
        internal const string TreeDensity = "Средняя плотность";

        internal int treeHumidity;
        internal string treeType;
        internal string treeProcessing;
        internal bool treePlates;
        internal int treePlatesWidth;
        internal int treePlatesDepth;

        internal Pine(int treeHumidity, string treeType, string treeProcessing, 
            bool treePlates, int treePlatesWidth, int treePlatesDepth) 
        {
            this.treeHumidity = treeHumidity;
            this.treeType = treeType;
            this.treeProcessing = treeProcessing;
            this.treePlates = treePlates;
            this.treePlatesWidth = treePlatesWidth;
            this.treePlatesDepth = treePlatesDepth;
        }

        internal static List<Pine> pines = new List<Pine>();

        internal static void AddTree()
        {
            Pine pine_test = new Pine(11, "eweer", "esfs", true, 12, 15);
            pines.Add(pine_test);
        }
    }
}
