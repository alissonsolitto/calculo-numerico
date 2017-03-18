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
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
            imprimirMatrix();
        }

        private void imprimirMatrix()
        {
            //Imprimir matriz
            for (int i = 0; i < frmMain.Vertice; i++)
            {
                for (int j = 0; j < frmMain.Vertice + 1; j++)
                {
                    richTextBox1.AppendText((frmMain.matrix[i, j]).ToString() + "\t");
                }

                richTextBox1.AppendText("\n");
            }

            richTextBox1.AppendText("\n ============================= Valores para o 'x' =============================");

            for (int i = 0; i < frmMain.Vertice; i++)
            {
                richTextBox1.AppendText(String.Format("\n x{0} = " + frmMain.valoresX[i], i + 1));
            }
        }
    }
}
