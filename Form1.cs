using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WersjagraficznaTychZadan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var wybor = comboBox1.SelectedItem as string;
            if (wybor == null) return;

            labelWagiPoczatkowe.Text = "Wagi poczatkowe";
            labelWagiKoncowe.Text = " Wagi koncowe";
            btnTestuj.Visible = true;
            WYniki12.Text = "";
            WszystkieWyniki.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTestuj_Click(object sender, EventArgs e)
        {
            string wybor = comboBox1.SelectedItem as string;
            switch (wybor)
            {
                case "XOR":
                    XOR();
                    break;
                case "XOR_NOR":
                    XOR_NOR();
                    break;
                case "Sumatorek":
                    Sumatorek();
                    break;
            }
        }
        private static Random rand = new Random();

        private void XOR()
        {
            int[] struktura = { 2, 2, 1 };
            double[][][] wagi = WylosujWagi(struktura);
          //  double[][][] wagi = new double[2][][];
           // wagi[0] = new double[2][];
            //wagi[1] = new double[1][];
           // wagi[0][0] = new double[] { 0.3, 0.1, 0.2 };
           //// wagi[0][1] = new double[] { 0.6, 0.4, 0.5 };
           // wagi[1][0] = new double[] { 0.9, 0.7, -0.8 };
            double parametrUczenia = 0.3;
            double[][] WejsciaSieci = new double[][]
           {
                    new double[] { 0, 0 },
                    new double[] { 0, 1 },
                    new double[] { 1, 0 },
                    new double[] { 1, 1 }
           };
            double [][] WejsciaSieci2 = WejsciaSieci.Select(w => w.ToArray()).ToArray(); ;//kopia dla wynikow aby wyniki nie wyswitlaly sie pomieszane
            double[] WyjsciaOczekiwane = { 0, 1, 1, 0 };
            WszystkieWynikiPrzed(WejsciaSieci2, struktura, wagi);
            GenerujWagiPoczatkowe(wagi);

            for (int epoka = 0; epoka < 10000; epoka++)
            {
                if (epoka > 0)
                {
                    MieszajDane(WejsciaSieci, WyjsciaOczekiwane);
                }
                for (int i = 0; i < WejsciaSieci.Length; i++)
                {
                    wagi = PropagacjaWsteczna(WejsciaSieci[i], new[] { WyjsciaOczekiwane[i] }, wagi, struktura, parametrUczenia);
                }
            }

            GenerujWagiKoncowe(wagi);
            WypiszWszystkieWyniki(WejsciaSieci2, struktura, wagi);

        }
        private void XOR_NOR()
        {
            int[] struktura = { 2, 2, 2, 2 };
            double[][][] wagi = WylosujWagi(struktura);
            double parametrUczenia = 0.1;

            double[][] WejsciaSieci = {
                new double[] { 0, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 1 }
            };
            double[][] WejsciaSieci2 = WejsciaSieci.Select(w => w.ToArray()).ToArray(); ;
            double[][] WyjsciaOczekiwane = {
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 0 }
            };
            WszystkieWynikiPrzed(WejsciaSieci2, struktura, wagi);
            GenerujWagiPoczatkowe(wagi);
            for (int epoka = 0; epoka < 40000; epoka++)
            {
                if (epoka > 0)
                {
                    MieszajDane(WejsciaSieci, WyjsciaOczekiwane);
                }
                for (int i = 0; i < WejsciaSieci.Length; i++)
                {
                    wagi = PropagacjaWsteczna(WejsciaSieci[i], WyjsciaOczekiwane[i], wagi, struktura, parametrUczenia);
                }
            }
            GenerujWagiKoncowe(wagi);
            WypiszWszystkieWyniki(WejsciaSieci2, struktura, wagi);
        }
        private void Sumatorek()
        {
            int[] struktura = { 3, 3, 2, 2 };
            double[][][] wagi = WylosujWagi(struktura);
            double parametrUczenia = 0.05;

            double[][] WejsciaSieci = {
                new double[] { 0, 0, 0 },
                new double[] { 0, 0, 1 },
                new double[] { 0, 1, 0 },
                new double[] { 0, 1, 1 },
                new double[] { 1, 0, 0 },
                new double[] { 1, 0, 1 },
                new double[] { 1, 1, 0 },
                new double[] { 1, 1, 1 }
             };
            double[][] WejsciaSieci2 = WejsciaSieci.Select(w => w.ToArray()).ToArray(); ;
            double[][] WyjsciaOczekiwane = {
                new double[] { 0, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 0, 1 },
                new double[] { 1, 1 }
            };
            WszystkieWynikiPrzed(WejsciaSieci2, struktura, wagi);
            GenerujWagiPoczatkowe(wagi);
            for (int epoka = 0; epoka < 80000; epoka++)
            {
                if (epoka > 0)
                {
                    MieszajDane(WejsciaSieci, WyjsciaOczekiwane);
                }
                for (int i = 0; i < WejsciaSieci.Length; i++)
                {
                    wagi = PropagacjaWsteczna(WejsciaSieci[i], WyjsciaOczekiwane[i], wagi, struktura, parametrUczenia);
                }
            }
            GenerujWagiKoncowe(wagi);
            WypiszWszystkieWyniki(WejsciaSieci2, struktura, wagi);
        }



        private static void MieszajDane(double[][] wejscia, double[] wyjscia)
        {
            for (int i = wejscia.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (wejscia[i], wejscia[j]) = (wejscia[j], wejscia[i]);
                (wyjscia[i], wyjscia[j]) = (wyjscia[j], wyjscia[i]);
            }
        }

        private static void MieszajDane(double[][] wejscia, double[][] wyjscia)
        {
            for (int i = wejscia.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (wejscia[i], wejscia[j]) = (wejscia[j], wejscia[i]);
                (wyjscia[i], wyjscia[j]) = (wyjscia[j], wyjscia[i]);
            }
        }

        public static double[][][] PropagacjaWsteczna(double[] wejscie, double[] OczekiwaneWyjscia, double[][][] wagi, int[] struktura, double parametrUczenia)
        {

            double[][] WynikiSieci = SiecNeuronowa(wejscie, wagi, struktura);
            double B = 1;

            double[][] BledyNeuronow = new double[struktura.Length - 1][]; //[NumerWarstwy][NumerNeuronu]


            int ostatniaWarstwa = struktura.Length - 1;
            BledyNeuronow[ostatniaWarstwa - 1] = new double[struktura[ostatniaWarstwa]];
            for (int i = 0; i < struktura[ostatniaWarstwa]; i++)//dla neuronow warstwy otatniej
            {
                BledyNeuronow[ostatniaWarstwa - 1][i] = (OczekiwaneWyjscia[i] - WynikiSieci[ostatniaWarstwa][i]) * (B * WynikiSieci[ostatniaWarstwa][i] * (1 - WynikiSieci[ostatniaWarstwa][i]));

            }

            for (int nrWarstwy = struktura.Length - 2; nrWarstwy > 0; nrWarstwy--)//dla neuronow warstw ukrytych -> iteracja po warstwach
            {
                BledyNeuronow[nrWarstwy - 1] = new double[struktura[nrWarstwy]];
                for (int i = 0; i < struktura[nrWarstwy]; i++)//iteracaja po liczbie neuronow w warstwie
                {
                    double SumaBledow = 0;
                    for (int j = 0; j < struktura[nrWarstwy + 1]; j++)//iteracja po liczbie neuronów w warstwie kolejnej -> każdy neuron z warstwy obeznej ma połączenie ze wszystkimi neuronami warstwy nastepnej
                    {
                        SumaBledow += BledyNeuronow[nrWarstwy][j] * wagi[nrWarstwy][j][i + 1];//tylko dla połączeń miedzy neuronami, błąd neuronu kolejnego* waga łącząca te nurony
                    }
                    BledyNeuronow[nrWarstwy - 1][i] = SumaBledow * (B * WynikiSieci[nrWarstwy][i] * (1 - WynikiSieci[nrWarstwy][i]));
                }

            }

            double[][][] WagiAfterUpdate = new double[wagi.Length][][];
            for (int i = 0; i < wagi.Length; i++)
            {
                WagiAfterUpdate[i] = new double[wagi[i].Length][];
                for (int j = 0; j < wagi[i].Length; j++)
                {
                    WagiAfterUpdate[i][j] = new double[wagi[i][j].Length];
                    WagiAfterUpdate[i][j][0] = wagi[i][j][0] +   parametrUczenia*   BledyNeuronow[i][j];//waga ukryta jako pierwsza
                    for (int k = 1; k < wagi[i][j].Length; k++)
                    {
                        WagiAfterUpdate[i][j][k] = wagi[i][j][k] + parametrUczenia * BledyNeuronow[i][j] * WynikiSieci[i][k - 1];
                    }
                }
            }

            return WagiAfterUpdate;
        }

        public static double[][] SiecNeuronowa(double[] wejscie, double[][][] Wagi, int[] struktura)
        {
            int lWarstw = struktura.Length;
            double[][] wyjscie = new double[lWarstw][]; // to będzie zlepek wszystkich wyników neuronów podzielonych na warstwy

            wyjscie[0] = new double[wejscie.Length];
            for (int i = 0; i < wejscie.Length; i++)
            {
                wyjscie[0][i] = wejscie[i];
            }


            for (int i = 1; i < lWarstw; i++)
            {
                int LiczbaNeuronowWarstwy = struktura[i];

                wyjscie[i] = new double[LiczbaNeuronowWarstwy];

                for (int n = 0; n < LiczbaNeuronowWarstwy; n++)
                {
                    double[] wagiNeuronu = Wagi[i - 1][n];

                    double z = Neuron(wagiNeuronu, wyjscie[i - 1]);
                    wyjscie[i][n] = FAktywacji(z);
                }
            }
            return wyjscie;
        }
        public static double FAktywacji(double WartNeurona, double B = 1.0)
        {
            return 1.0 / (1.0 + Math.Exp(-B * WartNeurona));
        }

        public static double Neuron(double[] Wagi, double[] wejscie)
        {
            double neuron = 0;
            neuron += Wagi[0];
            for (int j = 1; j <= wejscie.Length; j++)
            {
                neuron += Wagi[j] * wejscie[j - 1];
            }
            return neuron;
        }

        public static double[][][] WylosujWagi(int[] strukturaSieci)
        {
            //int liczbaWag = 0;
            double[][][] wagi = new double[strukturaSieci.Length - 1][][];
            for (int i = 0; i < strukturaSieci.Length - 1; i++)
            {
                wagi[i] = new double[strukturaSieci[i + 1]][];//+1 bo liczba wag zalezna od nastepnej warstwy
                for (int j = 0; j < strukturaSieci[i + 1]; j++)
                {
                    wagi[i][j] = new double[strukturaSieci[i] + 1];
                    for (int ktoraWaga = 0; ktoraWaga < strukturaSieci[i] + 1; ktoraWaga++)
                    {
                        wagi[i][j][ktoraWaga] = (rand.NextDouble() * 2) - 1;
                    }
                }
            }


            return wagi;
        }
        public void GenerujWagiPoczatkowe(double[][][] wagi)
        {
            StringBuilder sbPoczatkowe = new StringBuilder("Wagi początkowe:\n");
            for (int i = 0; i < wagi.Length; i++)
            {
                for (int j = 0; j < wagi[i].Length; j++)
                {
                    sbPoczatkowe.Append($"Warstwa {i}, Neuron {j}: ");
                    for (int k = 0; k < wagi[i][j].Length; k++)
                    {
                        sbPoczatkowe.Append($"{wagi[i][j][k]:F4} ");
                    }
                    sbPoczatkowe.AppendLine();
                }
            }
            labelWagiPoczatkowe.Text = sbPoczatkowe.ToString();
        }

        public void GenerujWagiKoncowe(double[][][] wagi)
        {
            StringBuilder sbKoncowe = new StringBuilder("Wagi końcowe:\n");
            for (int i = 0; i < wagi.Length; i++)
            {
                for (int j = 0; j < wagi[i].Length; j++)
                {
                    sbKoncowe.Append($"Warstwa {i}, Neuron {j}: ");
                    for (int k = 0; k < wagi[i][j].Length; k++)
                    {
                        sbKoncowe.Append($"{wagi[i][j][k]:F4} ");
                    }
                    sbKoncowe.AppendLine();
                }
            }
            labelWagiKoncowe.Text = sbKoncowe.ToString();
        }
        private void WszystkieWynikiPrzed(double[][] testoweWejscia, int[] struktura, double[][][] wagi)
        {
            var sb = new StringBuilder();

            foreach (var wejscie in testoweWejscia)
            {
                var wyjscie = SiecNeuronowa(wejscie, wagi, struktura).Last();
                string wejscieStr = string.Join(",  ", wejscie);
                string wyjscieStr = string.Join(",  ", wyjscie.Select(x => x.ToString("0.###")));
                sb.AppendLine($"[{wejscieStr}] -> [{wyjscieStr}]");
            }

            WYniki12.Text = sb.ToString();
        }

        private void WypiszWszystkieWyniki(double[][] testoweWejscia, int[] struktura, double[][][] wagi)
        {
            var sb = new StringBuilder();

            foreach (var wejscie in testoweWejscia)
            {
                var wyjscie = SiecNeuronowa(wejscie, wagi, struktura).Last();
                string wejscieStr = string.Join(",  ", wejscie);
                string wyjscieStr = string.Join(",  ", wyjscie.Select(x => x.ToString("0.###")));
                sb.AppendLine($"[{wejscieStr}] -> [{wyjscieStr}]");
            }

            WszystkieWyniki.Text = sb.ToString();
        }


    }
}
