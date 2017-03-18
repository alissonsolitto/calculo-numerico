using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Iniciar tabela
            tb.Columns.Add("A");
            tb.Columns.Add("B");
            tb.Columns.Add("C");
            tb.Columns.Add("F(A)");
            tb.Columns.Add("F(B)");
            tb.Columns.Add("F(C)");
            tb.Columns.Add("Precisão");            
        }

        #region Variáveis Globais
        public struct Resultados
        {
            public double raiz; 
            public int iteracao;

            public Resultados(double raiz, int iteracao)
            {
                this.raiz = raiz;
                this.iteracao = iteracao;
            }
        }

        List<Resultados> listaResultados = new List<Resultados>();
        DataTable tb = new DataTable();
        private int iteracao;
        private double auxInicial;
        private double auxFinal;        
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

        // Propriedade para obter o intevalo final
        private double final;
        public double Final
        {
            get
            {
                return Math.Truncate(final * Math.Pow(10, 4)) / Math.Pow(10, 4);
            }
            set
            {
                final = value;
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

        #region Métodos Úteis
        private double funcao(double x)
        {
            return (x * x) - x + Math.Sin(5 * x);
        }

        private Boolean positivo(double x)
        {
            return (x >= 0);
        }

        private void atualiza_posicao()
        {
            double fInicial = funcao(Inicial);
            double fFinal = funcao(Final);
            double fMedio = funcao(Medio);

            if(positivo(fInicial) == positivo(fMedio))
            {
                Inicial = Medio;
            }
            else if (positivo(fFinal) == positivo(fMedio))
            {
                Final = Medio;
            }
        }

        private void addLinha()
        {
            tb.Rows.Add(new String[] { Inicial.ToString(),
                                       Final.ToString(),
                                       Medio.ToString(),
                                       funcao(Inicial).ToString(),
                                       funcao(Final).ToString(),
                                       funcao(Medio).ToString(),                                       
                                       Parada.ToString()});
            iteracao++;
        }

        #endregion

        private void dicotomia(double precisao, double intervalo)
        {
            Inicial = auxInicial;
            Final   = auxInicial + intervalo;

            double ant = 0;
            iteracao   = 0;
            Parada     = 0;
            Medio      = 0;

            if (positivo(funcao(Inicial)) != positivo(funcao(Final)))
            { 
                do
                {
                    ant = Medio;
                    Medio = (Inicial + Final) / 2;
                    Parada = Math.Abs(Medio - ant);
                    addLinha();
                    atualiza_posicao();

                } while (Parada > precisao);

                listaResultados.Add(new Resultados(Medio, iteracao));
            }

            auxInicial += intervalo;
            if (auxInicial < auxFinal)
            {
                dicotomia(precisao, intervalo);                
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double intervalo = Convert.ToDouble(edtIntervalo.Text);
            Inicial = Convert.ToDouble(edtInicial.Text);
            Final = Convert.ToDouble(edtFinal.Text);

            // Lista
            listaResultados.Clear();

            // RichText
            rcText.Clear();
            rcText.Font = new Font("Consolas", 14f, FontStyle.Bold);

            // Grid
            tb.Clear();
            grd.DataSource = tb;            
            grd.Refresh();

            auxInicial = Inicial;
            auxFinal = Final;
            dicotomia(Math.Pow(10, -4), intervalo);


            foreach (Resultados resultado in listaResultados)
            {
                rcText.AppendText("Raiz encontrada: " + resultado.raiz + "  - Iterações necessárias: " + resultado.iteracao + "\n");                
            }            

            MessageBox.Show("Processo concluído com sucesso!");

        }
    }
}
