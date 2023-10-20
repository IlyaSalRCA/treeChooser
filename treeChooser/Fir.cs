using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeChooser
{
    internal class Fir : Tree
    {
        internal const string TreeColor = "Светлый, практически белый";
        internal const bool TreeCore = false;
        internal const string CoreColor = "-";
        internal const bool TreeResin = false;
        internal const string TreeMedullary = "Хорошо различимы, иной цвет";
        internal const string TreeDensity = "Низкая плотность";

        internal string treeHumidity;
        internal string treeType;
        internal string treeProcessing;
        internal bool treePlates;
        internal int treePlatesWidth;
        internal int treePlatesDepth;

        internal Fir(string treeHumidity, string treeType, string treeProcessing,
            bool treePlates, int treePlatesWidth, int treePlatesDepth)
        {
            this.treeHumidity = treeHumidity;
            this.treeType = treeType;
            this.treeProcessing = treeProcessing;
            this.treePlates = treePlates;
            this.treePlatesWidth = treePlatesWidth;
            this.treePlatesDepth = treePlatesDepth;
        }

        internal static List<Fir> firs = new List<Fir>();

        internal static void AddTree()
        {
            Fir fir_ = new Fir(11, "eweer", "esfs", true, 12, 15);

            firs.Add(fir_);
        }
    }
}
