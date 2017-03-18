namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMatriz = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarMatriz = new System.Windows.Forms.Button();
            this.txtNumVertice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMatriz
            // 
            this.pnlMatriz.Location = new System.Drawing.Point(12, 81);
            this.pnlMatriz.Name = "pnlMatriz";
            this.pnlMatriz.Size = new System.Drawing.Size(1137, 536);
            this.pnlMatriz.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnGerarMatriz);
            this.groupBox1.Controls.Add(this.txtNumVertice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnGerarMatriz
            // 
            this.btnGerarMatriz.Location = new System.Drawing.Point(341, 24);
            this.btnGerarMatriz.Name = "btnGerarMatriz";
            this.btnGerarMatriz.Size = new System.Drawing.Size(120, 23);
            this.btnGerarMatriz.TabIndex = 5;
            this.btnGerarMatriz.Text = "Gerar Matriz";
            this.btnGerarMatriz.UseVisualStyleBackColor = true;
            this.btnGerarMatriz.Click += new System.EventHandler(this.btnGerarMatriz_Click);
            // 
            // txtNumVertice
            // 
            this.txtNumVertice.Location = new System.Drawing.Point(235, 24);
            this.txtNumVertice.MaxLength = 2;
            this.txtNumVertice.Name = "txtNumVertice";
            this.txtNumVertice.Size = new System.Drawing.Size(100, 22);
            this.txtNumVertice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a quantidade de variáveis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gerar Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlMatriz);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangulação de Gauss";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMatriz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarMatriz;
        private System.Windows.Forms.TextBox txtNumVertice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

