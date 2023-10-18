using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeChooser
{
    abstract class Tree
    {
        string TreeColor { get; }
        bool TreeCore { get; }
        string CoreColor { get; }
        bool TreeResin { get; }
        string TreeMedullary { get; }
        string TreeDensity { get; }

        int treeHumidity;
        string treeProcessing;
        bool treePlates;
        int treePlatesWidth;
        int treePlatesDepth;

        List<Tree> trees;
    }
}
