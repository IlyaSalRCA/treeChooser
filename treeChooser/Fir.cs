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
        internal string treeProcessingSecond;
        internal bool treePlates;
        internal bool treePlatesWidthDepth;
        internal string nomenclatureCode;

        internal Fir(string treeHumidity, string treeType, string treeProcessing,
            string treeProcessingSecond, bool treePlates, bool treePlatesWidthDepth, string nomenclatureCode)
        {
            this.treeHumidity = treeHumidity; //Влажность
            this.treeType = treeType; //Вид дерева
            this.treeProcessing = treeProcessing; //Вид обработки
            this.treeProcessingSecond = treeProcessingSecond; //Вид обработки при торц. соед.
            this.treePlates = treePlates; //Наличие пласти
            this.treePlatesWidthDepth = treePlatesWidthDepth; //Ширина пласти
            this.nomenclatureCode = nomenclatureCode; //Код ТН ВЭД
        }

        internal static List<Fir> firs = new List<Fir>();

        internal static void AddTree()
        {
            Fir fir_1601 = new Fir("менее 22%", "-", "Шлифование или торцевое соединение", "Шлифование или строгание", false, false, "4407 12 160 1");
            Fir fir_1603 = new Fir("менее 22%", "-", "Шлифование или торцевое соединение", "Прочее", false, false, "4407 12 160 3");

            Fir fir_1604 = new Fir("22% и более", "-", "Шлифование или торцевое соединение", "-", true, true, "4407 12 160 4");
            Fir fir_1605 = new Fir("22% и более", "-", "Шлифование или торцевое соединение", "-", true, false, "4407 12 160 5");
            Fir fir_1609 = new Fir("22% и более", "-", "Шлифование или торцевое соединение", "-", false, false, "4407 12 160 9");

            Fir fir_3201 = new Fir("менее 22%", "Picea abies Karst.", "Строгание", "-", false, false, "4407 12 320 1");
            Fir fir_3205 = new Fir("22% и более", "Picea abies Karst.", "Строгание", "-", true, true, "4407 12 320 5");
            Fir fir_3206 = new Fir    ("22% и более", "Picea abies Karst.", "Строгание", "-", true, false, "4407 12 320 6");
            Fir fir_3209 = new Fir("22% и более", "Picea abies Karst.", "Строгание", "-", false, false, "4407 12 320 9");

            Fir fir_3901 = new Fir("менее 22%", "Иной", "Строгание", "-", false, false, "4407 12 390 1");
            Fir fir_3905 = new Fir("22% и более%", "Иной", "Строгание", "-", true, true, "4407 12 390 5");
            Fir fir_3906 = new Fir("22% и более", "Иной", "Строгание", "-", true, false, "4407 12 390 6");
            Fir fir_3909 = new Fir("22% и более", "Иной", "Строгание", "-", false, false, "4407 12 390 9");

            Fir fir_9901 = new Fir("менее 22%", "Иной", "Прочее", "-", false, false, "4407 12 990 1");
            Fir fir_9905 = new Fir("22% и более", "Иной", "Прочее", "-    ", true, true, "4407 12 990 5");
            Fir fir_9906 = new Fir("22% и более", "Иной", "Прочее", "-", true, false, "4407 12 990 6");
            Fir fir_9909 = new Fir("22% и более", "Иной", "Прочее", "-", false, false, "4407 12 990 9");

            Fir fir_9201 = new Fir("менее 22%", "Picea abies Karst.", "Прочее", "-", false, false, "4407 12 920 1");
            Fir fir_9205 = new Fir("22% и более", "Picea abies Karst.", "Прочее", "-", true, true, "4407 12 920 5");
            Fir fir_9206 = new Fir("22% и более", "Picea abies Karst.", "Прочее", "-", true, false, "4407 12 920 6");
            Fir fir_9209 = new Fir("22% и более", "Picea abies Karst.", "Прочее", "-", false, false, "4407 12 920 9");


            firs.Add(fir_1601);
            firs.Add(fir_1603);
            firs.Add(fir_1604);
            firs.Add(fir_1605);
            firs.Add(fir_1609);

            firs.Add(fir_3201);
            firs.Add(fir_3205);
            firs.Add(fir_3206);
            firs.Add(fir_3209);

            firs.Add(fir_3901);
            firs.Add(fir_3905);
            firs.Add(fir_3906);
            firs.Add(fir_3909);

            firs.Add(fir_9901);
            firs.Add(fir_9905);
            firs.Add(fir_9906);
            firs.Add(fir_9909);

            firs.Add(fir_9201);
            firs.Add(fir_9205);
            firs.Add(fir_9206);
            firs.Add(fir_9209);

        }
    }
}
