using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeChooser
{
    internal class Pine : Tree
    {
        internal const string TreeColor = "Жёлтый оттенок с выраженным рисунком";
        internal const bool TreeCore = true;
        internal const string CoreColor = "От розового до буровато-красного";
        internal const bool TreeResin = true;
        internal const string TreeMedullary = "Слабо заметны";
        internal const string TreeDensity = "Средняя плотность";

        internal string treeHumidity;
        internal string treeType;
        internal string treeProcessing;
        internal string treeProcessingSecond;
        internal bool treePlates;
        internal bool treePlatesWidth;
        internal bool treePlatesDepth;
        internal string nomenclatureCode;

        internal Pine(string treeHumidity, string treeType, string treeProcessing, 
            string treeProcessingSecond, bool treePlates, bool treePlatesWidth, bool treePlatesDepth, string nomenclatureCode) 
        {
            this.treeHumidity = treeHumidity; //Влажность
            this.treeType = treeType; //Вид дерева
            this.treeProcessing = treeProcessing; //Вид обработки
            this.treeProcessingSecond = treeProcessingSecond; //Вид обработки при торц. соед.
            this.treePlates = treePlates; //Наличие пласти
            this.treePlatesWidth = treePlatesWidth; //Ширина пласти
            this.treePlatesDepth = treePlatesDepth; //Толщина пласти
            this.nomenclatureCode = nomenclatureCode; //Код ТН ВЭД
        }

        internal static List<Pine> pines = new List<Pine>();

        internal static void AddTree()
        {
            Pine pine_1601 = new Pine("менее 22%", "-", "Шлифование или торцевое соединение", "Шлифование или строгание", false, false, false, "4407 11 160 1");
            Pine pine_1603 = new Pine("менее 22%", "-", "Шлифование или торцевое соединение", "Прочее", false, false, false, "4407 11 160 3");

            Pine pine_1604 = new Pine("22% и более", "-", "Шлифование или торцевое соединение", "-", true, true, true, "4407 11 160 4");
            Pine pine_1605 = new Pine("22% и более", "-", "Шлифование или торцевое соединение", "-", true, false, false, "4407 11 160 5");
            Pine pine_1609 = new Pine("22% и более", "-", "Шлифование или торцевое соединение", "-", false, false, false, "4407 11 160 9");

            Pine pine_3401 = new Pine("менее 22%", "Pinus sylvestris L.", "Строгание", "-", false, false, false, "4407 11 340 1");
            Pine pine_3405 = new Pine("22% и более", "Pinus sylvestris L.", "Строгание", "-", true, true, true, "4407 11 340 5");
            Pine pine_3406 = new Pine("22% и более", "Pinus sylvestris L.", "Строгание", "-", true, false, false, "4407 11 340 6");
            Pine pine_3409 = new Pine("22% и более", "Pinus sylvestris L.", "Строгание", "-", false, false, false, "4407 11 340 9");

            Pine pine_3901 = new Pine("менее 22%", "Иной", "Строгание", "-", false, false, false, "4407 11 390 1");
            Pine pine_3905 = new Pine("22% и более%", "Иной", "Строгание", "-", true, true, true, "4407 11 390 5");
            Pine pine_3906 = new Pine("22% и более", "Иной", "Строгание", "-", true, false, false, "4407 11 390 6");
            Pine pine_3909 = new Pine("22% и более", "Иной", "Строгание", "-", false, false, false, "4407 11 390 9");

            Pine pine_9901 = new Pine("менее 22%", "Иной", "Прочее", "-", false, false, false, "4407 11 990 1");
            Pine pine_9905 = new Pine("22% и более", "Иной", "Прочее", "-    ", true, true, true, "4407 11 990 5");
            Pine pine_9906 = new Pine("22% и более", "Иной", "Прочее", "-", true, false, false, "4407 11 990 6");
            Pine pine_9909 = new Pine("22% и более", "Иной", "Прочее", "-", false, false, false, "4407 11 990 9");

            Pine pine_9401 = new Pine("менее 22%", "Pinus sylvestris L.", "Прочее", "-", false, false, false, "4407 11 940 1");
            Pine pine_9405 = new Pine("22% и более", "Pinus sylvestris L.", "Прочее", "-", true, true, true, "4407 11 940 5");
            Pine pine_9406 = new Pine("22% и более", "Pinus sylvestris L.", "Прочее", "-", true, false, false, "4407 11 940 6");
            Pine pine_9409 = new Pine("22% и более", "Pinus sylvestris L.", "Прочее", "-", false, false, false, "4407 11 940 9");


            pines.Add(pine_1601);
            pines.Add(pine_1603);
            pines.Add(pine_1604);
            pines.Add(pine_1605);
            pines.Add(pine_1609);

            pines.Add(pine_3401);
            pines.Add(pine_3405);
            pines.Add(pine_3406);
            pines.Add(pine_3409);

            pines.Add(pine_3901);
            pines.Add(pine_3905);
            pines.Add(pine_3906);
            pines.Add(pine_3909);

            pines.Add(pine_9901);
            pines.Add(pine_9905);
            pines.Add(pine_9906);
            pines.Add(pine_9909);

            pines.Add(pine_9401);
            pines.Add(pine_9405);
            pines.Add(pine_9406);
            pines.Add(pine_9409);

        }
    }
}
