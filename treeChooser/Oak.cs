using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeChooser
{
    internal class Oak : Tree
    {
        internal const string TreeColor = "От жёлто-коричневого до коричневого";
        internal const bool TreeCore = true;
        internal const string CoreColor = "От темно-бурого до желтовато-коричневого";
        internal const bool TreeResin = false;
        internal const string TreeMedullary = "Хорошо различимы, светло-коричневые";
        internal const string TreeDensity = "Высокая плотность";

        internal string treeHumidity;
        internal string treeProcessing;
        internal bool treePlates;
        internal int treePlatesWidth;
        internal int treePlatesDepth;

        internal Oak(string treeHumidity, string treeProcessing,
            bool treePlates, int treePlatesWidth, int treePlatesDepth)
        {
            this.treeHumidity = treeHumidity;
            this.treeProcessing = treeProcessing;
            this.treePlates = treePlates;
            this.treePlatesWidth = treePlatesWidth;
            this.treePlatesDepth = treePlatesDepth;
        }

        internal static List<Oak> firs = new List<Oak>();

        internal static void AddTree()
        {
            Oak oak_ = new Oak(11, "eweer", true, 12, 15);

            firs.Add(oak_);
        }
    }
}
