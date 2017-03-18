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
    public partial class frmMain : Form
    {

        public static int Vertice;
        public static double[,] matrix;
        public static double[] valoresX;

        public frmMain()
        {
            InitializeComponent();
        }

        private double truncate(double x)
        {
            x *= 100; // duas casas decimais
            x = Math.Truncate(x);
            x /= 100;

            return x;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            int linha = Convert.ToInt32(txt.Name.Substring(3, 1));
            int coluna = Convert.ToInt32(txt.Name.Substring(4, 1));

            if ((!txt.Text.Equals("+")) && (!txt.Text.Equals("-")))
            {
                matrix[linha, coluna] = Convert.ToInt32(txt.Text.Equals("") ? "0" : txt.Text);
            }

        }

        private void btnGerarMatriz_Click(object sender, EventArgs e)
        {
            Vertice = Convert.ToInt32(txtNumVertice.Text);
            
            if (Vertice > 10)
            {
                MessageBox.Show("O número máximo de varáveis aceito é 10");
            }
            else
            {
                pnlMatriz.Controls.Clear();
                matrix = new double[Vertice, Vertice + 1]; // Porque tem a coluna do "B" que é o resultado
                //matrix = new double[,] {  {4, -1, 0, -1, 0, 0, 0, 0, 0, 0, -110},
                //                          {-1, 4, -1, 0, -1, 0, 0, 0, 0, 0, -30},
                //                          {0, -1, 4, 0, 0, -1, 0, 0, 0, 0, -40 },
                //                          {-1, 0, 0, 4, -1, 0, 0, 0, 0, 0, -110},
                //                          {0, -1, 0, -1, 4, -1, -1, 0, 0, 0, 0 },
                //                          {0, 0, -1, 0, -1, 4, 0, -1, 0, 0, -15},
                //                          {0, 0, 0, 0, -1, 0, 4, -1, 0, 0, -90 },
                //                          {0, 0, 0, 0, 0, -1, -1, 4, -1, 0, -25 },
                //                          {0, 0, 0, 0, 0, 0, 0, -1, 4, -1, -55 },
                //                          {0, 0, 0, 0, 0, 0, 0, 0, -1, 4, -65 }
                //                        };


                int Left = 30;
                int Top = 30;
                int Width = 80;

                for (int i = 0; i < Vertice; i++)
                {
                    for (int j = 0; j < Vertice + 1; j++)
                    {
                        TextBox txt = new TextBox();
                        txt.Name = String.Format("txt{0}{1}", i, j);

                        //Posição na tela
                        txt.Parent = pnlMatriz;
                        txt.Left = Left + 5;
                        txt.Top = Top;
                        txt.Width = Width;

                        if (j == 0)//caso seja a primeira coluna
                        {
                            Label lbl = new Label();
                            lbl.Parent = pnlMatriz;
                            lbl.Left = 5;
                            lbl.Top = Top;
                            lbl.Text = String.Format("{0}", i + 1);
                        }

                        if (i == 0) //caso seja a primeira linha inseri o cabeçalho
                        {
                            Label lbl = new Label();
                            lbl.Parent = pnlMatriz;
                            lbl.Left = Left + (Width / 2);
                            lbl.Top = 5;
                            lbl.Text = String.Format("{0}", j + 1);
                        }

                        Left += Width + 20;

                        //Evento
                        txt.KeyUp += this.onKeyUp;
                    }

                    Top += 50;
                    Left = 30;
                }
            }
        }

        private void calcularX(double[,] matrix)
        {
            int linha = Vertice;
            int col = Vertice + 1;
            valoresX = new double[linha];

            for (int i = linha - 1; i >= 0; i--)
            {
                for(int j = col - 2; j >= i ; j--) // Não pega o valor após o "="
                {
                    if((i == linha - 1) && (i == j)) // Ultima linha, só precisa dividir
                    {
                        valoresX[i] = truncate(matrix[i, j + 1] / matrix[i, j]);
                    }
                    else
                    {
                        // Quando chegar no "x" da linha
                        if(i == j)
                        {
                            // Trocar os valores de lado da equação
                            valoresX[i] = (valoresX[i] * -1) + matrix[i, col - 1];

                            // Calcula o "x" da linha
                            valoresX[i] = truncate(valoresX[i] / matrix[i, j]);
                        }
                        else
                        {
                            valoresX[i] += matrix[i, j] * valoresX[j]; // Substitui pelo "x" calculadora até chegar na incognita novamente
                        }
                    }
                }
            }
        }

        private void efetuarTriangulacao()
        {
            int linha = Vertice;
            int col = Vertice + 1;

            double[] linhaAnt = new double[col];
            double[] linhaAtual = new double[col];

            // Zerar elementos da matrix
            for (int i = 1; i < linha; i++) // Linha
            {
                for (int a = 0; a < i; a++) // Percorre a coluna de acordo com o numero da linha
                {
                    if (matrix[i, a] != 0) //Precisa zerar o elemento
                    {
                        for (int b = 0; b < col; b++)
                        {
                            linhaAnt[b] = truncate(matrix[a, b] * (matrix[i, a] / matrix[a, a]));  // Linha zero
                            linhaAtual[b] = matrix[i, b];
                        }

                        // Subtrair as linhas
                        for (int b = 0; b < col; b++)
                        {
                            matrix[i, b] = truncate(linhaAnt[b] - linhaAtual[b]);
                        }
                    }
                }
            }

            calcularX(matrix);

            // Chama o frmResultado
            new frmResultado().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            efetuarTriangulacao();
        }
    }
}
