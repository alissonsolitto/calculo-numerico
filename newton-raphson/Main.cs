using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Iniciar tabela
            tb.Columns.Add("X");
            tb.Columns.Add("F(X)");
            tb.Columns.Add("F'(X)");
            tb.Columns.Add("F(X)/F'(X)");            
            tb.Columns.Add("Precisão");
        }

        #region Variáveis Globais
        DataTable tb = new DataTable();
        private int iteracao;
        private double auxInicial;        
        #endregion

        #region Propriedades
        // Propriedade para obter o intevalo inicial
        private double inicial;
        public double Inicial
        {
            get
            {
                return Math.Truncate(inicial * Math.Pow(10, 4)) / Math.Pow(10, 4);
            }
            set
            {
                inicial = value;
            }
        }

        // Propriedade para obter o ponto medio
        private double medio;
        public double Medio
        {
            get
            {
                return Math.Truncate(medio * Math.Pow(10, 4)) / Math.Pow(10, 4);
            }
            set
            {
                medio = value;
            }
        }

        // Propriedade para obter o ponto de parada
        private double parada;
        public double Parada
        {
            get
            {
                return Math.Truncate(parada * Math.Pow(10, 4)) / Math.Pow(10, 4);
            }
            set
            {
                parada = value;
            }
        }
        #endregion

        #region Métodos
        private double funcao(double x)
        {
            return 37.104740 + (3.15122 * x) - (x * x);
        }

        private double derivada(double x)
        {
            return 3.15122 - (2 * x);            
        }

        private void addLinha()
        {
            tb.Rows.Add(new String[] { Inicial.ToString(),
                                       funcao(Inicial).ToString(),
                                       derivada(Inicial).ToString(),
                                       (funcao(Inicial) / derivada(Inicial)).ToString(),
                                       Parada.ToString()});
            iteracao++;
        }

        #endregion

        private void newton_raphson(double precisao)
        {
            double ant = 0;
            iteracao = 0;
            Parada = 0;
            Medio = 0;

            do
            {
                Inicial = auxInicial;

                Medio = (funcao(Inicial) / derivada(Inicial));
                auxInicial = auxInicial - Medio;

                Parada = Math.Abs(Inicial - ant);
                ant = Inicial;

                addLinha();

            } while (Parada > precisao);

            rcText.AppendText("Raiz encontrada: " + Inicial.ToString() + "  - Iterações necessárias: " + iteracao.ToString() + "\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Inicial = Convert.ToDouble(edtInicial.Text);
            
            // RichText
            rcText.Clear();
            rcText.Font = new Font("Consolas", 14f, FontStyle.Bold);

            // Grid
            tb.Clear();
            grd.DataSource = tb;
            grd.Refresh();

            auxInicial = Inicial;            
            newton_raphson(Math.Pow(10, -4));

            MessageBox.Show("Processo concluído com sucesso!");

        }
    }
}
