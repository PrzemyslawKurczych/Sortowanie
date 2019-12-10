using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PositioningElements
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        void Przetworz(sbyte positionnr, sbyte positionx, sbyte positiony, sbyte positionstb, sbyte positionzrd, sbyte positionbpp, sbyte positionrzg, string path)
        {
            var lineCount = File.ReadLines(path).Count() - 1;
            BorderPoint[] point = new BorderPoint[lineCount];
            string s;
            int w = 0;
            StreamReader sr = new StreamReader(path);
            string headerline = sr.ReadLine();
            while ((s = sr.ReadLine()) != null)
            {

                string[] line = s.Split('\t');
                string number = line[positionnr];
                double x =0;
                x= GetDouble(line[positionx],x);
                double y=0;
                y = GetDouble(line[positionx], y);
                byte stb = Convert.ToByte(line[positionstb]);
                byte zrd = Convert.ToByte(line[positionzrd]);
                byte bpp = Convert.ToByte(line[positionbpp]);
                byte rzg = Convert.ToByte(line[positionrzg]);
                point[w] = new BorderPoint(number, x, y, rzg, stb, zrd, bpp);
                w++;
            };
            sr.Close();
            var savePath = Path.GetDirectoryName(path);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = savePath;
            saveFileDialog.Filter = "Pliki txt (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (BorderPoint p in point)
                    {
                        outputFile.WriteLine(p.ChangedLine());
                    }
                }
            }
        }

        private void BtEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wskaż plik do posortowania";
                openFileDialog.Filter = "Pliki txt (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    SortingElements positions = new SortingElements();
                    positions.PositionsOf(filePath);
                    Przetworz(positions.Nr, positions.X, positions.Y, positions.Stb, positions.Zrd, positions.Bpp, positions.Rzg, filePath);
                }
            }

        }

        public static double GetDouble(string value, double defaultValue)
        {
            double result;

            //Try parsing in the current culture
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then in neutral language
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
            }

            return result;
        }
    }
}


