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
        internal string treeProcessingSecond;
        internal string lumberType;
        internal bool treePlates;
        internal bool treePlatesWidth;
        internal bool treePlatesDepth;
        internal string nomenclatureCode;

        internal Oak(string treeHumidity, string lumberType, string treeProcessing, string treeProcessingSecond,
            bool treePlates, bool treePlatesWidth, bool treePlatesDepth, string nomenclatureCode)
        {
            this.treeHumidity = treeHumidity; //Влажность
            this.treeProcessing = treeProcessing; //Вид обработки
            this.treeProcessingSecond = treeProcessingSecond; //Вид обработки при торц. соед.
            this.lumberType = lumberType; //Вид пиломатериала
            this.treePlates = treePlates; //Наличие пласти
            this.treePlatesWidth = treePlatesWidth; //Ширина пласти
            this.treePlatesDepth = treePlatesDepth; //Толщина пласти
            this.nomenclatureCode = nomenclatureCode; //Код ТН ВЭД
        }

        internal static List<Oak> oaks = new List<Oak>();

        internal static void AddTree()
        {
            Oak oak_1501 = new Oak("менее 22%", "Иной", "Шлифование или торцевое соединение", "Шлифование или строгание", false, false, false, "4407 91 150 1");
            Oak oak_1503 = new Oak("менее 22%", "Иной", "Шлифование или торцевое соединение", "Прочее", false, false, false, "4407 91 150 3");

            Oak oak_1504 = new Oak("22% и более", "Иной", "Шлифование или торцевое соединение", "-", true, true, true, "4407 91 150 4");
            Oak oak_1505 = new Oak("22% и более", "Иной", "Шлифование или торцевое соединение", "-", true, false, false, "4407 91 150 5");
            Oak oak_1509 = new Oak("22% и более", "Иной", "Шлифование или торцевое соединение", "-", false, false, false, "4407 91 150 9");

            Oak oak_3100 = new Oak("-", "бруски, планки и фриз для паркета или деревянного покрытия полов,несобранные", "Строгание", "-", false, false, false, "4407 91 310 0");

            Oak oak_3901 = new Oak("менее 22%", "Иной", "Строгание", "-", false, false, false, "4407 91 390 1");
            Oak oak_3905 = new Oak("22% и более", "Иной", "Строгание", "-", true, true, true, "4407 91 390 5");
            Oak oak_3906 = new Oak("22% и более", "Иной", "Строгание", "-", true, false, false, "4407 91 390 6");
            Oak oak_3909 = new Oak("22% и более", "Иной", "Строгание", "-", false, false, false, "4407 91 390 9");

            Oak oak_9001 = new Oak("менее 22%", "Иной", "Прочее", "-", false, false, false, "4407 91 900 1");
            Oak oak_9005 = new Oak("22% и более", "Иной", "Прочее", "-    ", true, true, true, "4407 91 900 5");
            Oak oak_9006 = new Oak("22% и более", "Иной", "Прочее", "-", true, false, false, "4407 91 900 6");
            Oak oak_9009 = new Oak("22% и более", "Иной", "Прочее", "-", false, false, false, "4407 91 900 9");

            oaks.Add(oak_1501);
            oaks.Add(oak_1503);
            oaks.Add(oak_1504);
            oaks.Add(oak_1505);
            oaks.Add(oak_1509);

            oaks.Add(oak_3100);

            oaks.Add(oak_3901);
            oaks.Add(oak_3905);
            oaks.Add(oak_3906);
            oaks.Add(oak_3909);

            oaks.Add(oak_9001);
            oaks.Add(oak_9005);
            oaks.Add(oak_9006);
            oaks.Add(oak_9009);
        }
    }
}
