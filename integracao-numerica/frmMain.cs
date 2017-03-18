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
        public frmMain()
        {
            InitializeComponent();
        }

        #region Interface

        private void tbParticao_ValueChanged(object sender, EventArgs e)
        {
            txtValorParticao.Text = tbParticao.Value.ToString();
        }
        private void tbVezes_ValueChanged(object sender, EventArgs e)
        {
            txtVezes.Text = tbVezes.Value.ToString();
        }

        private void tbIteracao_ValueChanged(object sender, EventArgs e)
        {
            txtIteracao.Text = tbIteracao.Value.ToString();
        }

        private void txtValorParticao_KeyUp(object sender, KeyEventArgs e)
        {
            txtValorParticao.Text = (txtValorParticao.Text.Equals("") ? "0" : txtValorParticao.Text);
            int validacao = Convert.ToInt32(txtValorParticao.Text);

            //if(validacao > 100)
            //{
            //    MessageBox.Show("O valor máximo permitido é 100");
            //    txtValorParticao.Text = "100";
            //}
            //else
            {
                tbParticao.Value = validacao;
            }
            
        }

        private void txtVezes_KeyUp(object sender, KeyEventArgs e)
        {
            txtVezes.Text = (txtVezes.Text.Equals("") ? "0" : txtVezes.Text);
            int validacao = Convert.ToInt32(txtVezes.Text);

            //if (validacao > 10)
            //{
            //    MessageBox.Show("O valor máximo permitido é 10");
            //    txtVezes.Text = "10";
            //}
            //else
            {
                tbVezes.Value = validacao;
            }
        }

        private void txtIteracao_KeyUp(object sender, KeyEventArgs e)
        {
            txtIteracao.Text = (txtIteracao.Text.Equals("") ? "0" : txtIteracao.Text);
            int validacao = Convert.ToInt32(txtIteracao.Text);

            //if (validacao > 10)
            //{
            //    MessageBox.Show("O valor máximo permitido é 10");
            //    txtIteracao.Text = "10";
            //}
            //else
            //{
                tbIteracao.Value = validacao;
            //}
        }

        #endregion

        private decimal truncate(decimal x)
        {
            x *= (decimal)Math.Pow(10, 10); // 10 casas decimais
            x = Math.Truncate(x);
            x /= (decimal)Math.Pow(10, 10);

            return x;
        }

        private decimal getFuncao(decimal x)
        {
            //return truncate(Convert.ToDecimal(Math.Pow(Math.E, -Math.Pow(aux,2))));
            //return Convert.ToDecimal(truncate(Math.Log(2 + Math.Pow(x, 0.5))));

            double aux = (double)x;
            return Convert.ToDecimal(2 *Math.Sqrt(1 - Math.Pow(aux, 2)));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // Matrix
            String[] cabecalho = new String[6] { "N", "Xn", "Xn+1", "F(X)", "F(Xn+1)", "Area" };
            decimal[,] matrix;
            decimal[] areas;

            // Intervalo
            decimal inicial = Convert.ToDecimal(txtIntervaloInicial.Text);
            decimal final = Convert.ToDecimal(txtIntervaloFinal.Text);
            
            int particao = tbParticao.Value;
            int vezes = tbVezes.Value;
            int iteracao = tbIteracao.Value;

            int parada = 0; // começar da linha que parou na matrix
            int qtdLinha = particao;
            int ant = particao;

            for (int i = 1; i < iteracao; i++)
            {
                qtdLinha = (ant * vezes) + qtdLinha;
                ant = ant * vezes;
            }

            matrix = new decimal[qtdLinha, 6];
            areas = new decimal[iteracao];

            for (int i = 0; i < iteracao; i++) // Quantidade de iterações
            {
                if(i > 0) // Depois da primeira iteração
                {
                    particao *= vezes;
                }

                decimal deltaX = (final - inicial) / (decimal)particao;
                int countParticao = 0;

                // Cabeçalho
                richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                for (int j = 0; j < 6; j++)
                {
                    if (j == 3)
                    {
                        richTextBox1.AppendText((cabecalho[j]).ToString() + "|");
                    }
                    else
                    {
                        richTextBox1.AppendText((cabecalho[j]).ToString() + "|");
                    }

                }
                richTextBox1.AppendText("\n");
                richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 10);
                richTextBox1.SelectionColor = System.Drawing.Color.Black;

                for (int j = parada; countParticao < particao; j++) // Quantidade de partições
                {
                    if(countParticao == 0)
                    {
                        matrix[j, 0] = countParticao++;
                        matrix[j, 1] = inicial;
                        matrix[j, 2] = inicial + deltaX;
                        matrix[j, 3] = getFuncao(inicial);
                        matrix[j, 4] = getFuncao(inicial + deltaX);

                        decimal aux = matrix[j, 3] + matrix[j, 4];
                        aux = aux / 2;
                        aux = aux * deltaX;
                        matrix[j, 5] = aux;

                        //matrix[j, 5] = truncate((Math.Abs(matrix[j, 3]) + Math.Abs(matrix[j, 4]) / 2) * deltaX);
                    }
                    else
                    {
                        matrix[j, 0] = countParticao++;
                        matrix[j, 1] = matrix[j - 1, 2];
                        matrix[j, 2] = matrix[j, 1] + deltaX;
                        matrix[j, 3] = getFuncao(matrix[j, 1]);
                        matrix[j, 4] = getFuncao(matrix[j, 2]);

                        decimal aux = matrix[j, 3] + matrix[j, 4];
                        aux = aux / 2;
                        aux = aux * deltaX;
                        matrix[j, 5] = aux;

                        //matrix[j, 5] = truncate((Math.Abs(matrix[j, 3]) + Math.Abs(matrix[j, 4]) / 2) * deltaX);
                    }

                    areas[i] += Math.Abs(matrix[j, 5]);

                    // Imprimir linha na tela
                    for (int a = 0; a < 6; a++)
                    {
                        richTextBox1.AppendText((matrix[j, a]).ToString() + "|");
                    }
                    richTextBox1.AppendText("\n");

                }

                parada += particao;
                richTextBox1.AppendText("\n");
            }

            //Imprimir as áreas
            richTextBox2.Clear();
            // Cabeçalho
            richTextBox2.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            richTextBox2.SelectionColor = System.Drawing.Color.Blue;

            richTextBox2.AppendText("N |");
            richTextBox2.AppendText("Area(N) |");
            richTextBox2.AppendText("Area(N - 1) |");
            richTextBox2.AppendText("Diferença |");

            richTextBox2.AppendText("\n");
            richTextBox2.SelectionFont = new Font("Microsoft Sans Serif", 10);
            richTextBox2.SelectionColor = System.Drawing.Color.Black;
            
            for (int i = 0; i < iteracao; i++)
            {
                richTextBox2.AppendText(i.ToString() + "|");

                // Atual
                richTextBox2.AppendText(areas[i].ToString() + "|");

                // Anterior
                if(i == 0)
                    richTextBox2.AppendText("----------|");
                else
                    richTextBox2.AppendText(areas[i - 1].ToString() + "|");

                // Difença
                decimal dif = areas[i];

                if (i > 0)
                {
                    dif = Math.Abs(dif - areas[i - 1]);
                }

                richTextBox2.AppendText(dif.ToString() + "|");
                richTextBox2.AppendText("\n");
            }
        }
    }
}
