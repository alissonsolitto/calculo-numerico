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
            this.gbxIntervalo = new System.Windows.Forms.GroupBox();
            this.txtIntervaloFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntervaloInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxParticao = new System.Windows.Forms.GroupBox();
            this.txtValorParticao = new System.Windows.Forms.TextBox();
            this.tbParticao = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVezes = new System.Windows.Forms.TextBox();
            this.tbVezes = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIteracao = new System.Windows.Forms.TextBox();
            this.tbIteracao = new System.Windows.Forms.TrackBar();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.gbxIntervalo.SuspendLayout();
            this.gbxParticao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVezes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIteracao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxIntervalo
            // 
            this.gbxIntervalo.Controls.Add(this.txtIntervaloFinal);
            this.gbxIntervalo.Controls.Add(this.label2);
            this.gbxIntervalo.Controls.Add(this.txtIntervaloInicial);
            this.gbxIntervalo.Controls.Add(this.label1);
            this.gbxIntervalo.Location = new System.Drawing.Point(12, 12);
            this.gbxIntervalo.Name = "gbxIntervalo";
            this.gbxIntervalo.Size = new System.Drawing.Size(390, 85);
            this.gbxIntervalo.TabIndex = 3;
            this.gbxIntervalo.TabStop = false;
            this.gbxIntervalo.Text = " Intervalo: ";
            // 
            // txtIntervaloFinal
            // 
            this.txtIntervaloFinal.Location = new System.Drawing.Point(290, 37);
            this.txtIntervaloFinal.Name = "txtIntervaloFinal";
            this.txtIntervaloFinal.Size = new System.Drawing.Size(88, 22);
            this.txtIntervaloFinal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Final:";
            // 
            // txtIntervaloInicial
            // 
            this.txtIntervaloInicial.Location = new System.Drawing.Point(67, 37);
            this.txtIntervaloInicial.Name = "txtIntervaloInicial";
            this.txtIntervaloInicial.Size = new System.Drawing.Size(88, 22);
            this.txtIntervaloInicial.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicial:";
            // 
            // gbxParticao
            // 
            this.gbxParticao.Controls.Add(this.txtValorParticao);
            this.gbxParticao.Controls.Add(this.tbParticao);
            this.gbxParticao.Location = new System.Drawing.Point(408, 12);
            this.gbxParticao.Name = "gbxParticao";
            this.gbxParticao.Size = new System.Drawing.Size(390, 85);
            this.gbxParticao.TabIndex = 6;
            this.gbxParticao.TabStop = false;
            this.gbxParticao.Text = " Partições: ";
            // 
            // txtValorParticao
            // 
            this.txtValorParticao.Location = new System.Drawing.Point(328, 21);
            this.txtValorParticao.MaxLength = 5;
            this.txtValorParticao.Name = "txtValorParticao";
            this.txtValorParticao.Size = new System.Drawing.Size(50, 22);
            this.txtValorParticao.TabIndex = 5;
            this.txtValorParticao.Text = "10";
            this.txtValorParticao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorParticao_KeyUp);
            // 
            // tbParticao
            // 
            this.tbParticao.Location = new System.Drawing.Point(17, 21);
            this.tbParticao.Maximum = 10000;
            this.tbParticao.Name = "tbParticao";
            this.tbParticao.Size = new System.Drawing.Size(305, 56);
            this.tbParticao.TabIndex = 1;
            this.tbParticao.Value = 10;
            this.tbParticao.ValueChanged += new System.EventHandler(this.tbParticao_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVezes);
            this.groupBox1.Controls.Add(this.tbVezes);
            this.groupBox1.Location = new System.Drawing.Point(408, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Aumentar Constantemente: ";
            // 
            // txtVezes
            // 
            this.txtVezes.Location = new System.Drawing.Point(328, 21);
            this.txtVezes.MaxLength = 5;
            this.txtVezes.Name = "txtVezes";
            this.txtVezes.Size = new System.Drawing.Size(50, 22);
            this.txtVezes.TabIndex = 5;
            this.txtVezes.Text = "2";
            this.txtVezes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVezes_KeyUp);
            // 
            // tbVezes
            // 
            this.tbVezes.Location = new System.Drawing.Point(17, 21);
            this.tbVezes.Maximum = 10000;
            this.tbVezes.Name = "tbVezes";
            this.tbVezes.Size = new System.Drawing.Size(305, 56);
            this.tbVezes.TabIndex = 1;
            this.tbVezes.Value = 2;
            this.tbVezes.ValueChanged += new System.EventHandler(this.tbVezes_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIteracao);
            this.groupBox2.Controls.Add(this.tbIteracao);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 85);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Iterações: ";
            // 
            // txtIteracao
            // 
            this.txtIteracao.Location = new System.Drawing.Point(328, 21);
            this.txtIteracao.MaxLength = 5;
            this.txtIteracao.Name = "txtIteracao";
            this.txtIteracao.Size = new System.Drawing.Size(50, 22);
            this.txtIteracao.TabIndex = 5;
            this.txtIteracao.Text = "5";
            this.txtIteracao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIteracao_KeyUp);
            // 
            // tbIteracao
            // 
            this.tbIteracao.Location = new System.Drawing.Point(17, 21);
            this.tbIteracao.Maximum = 10000;
            this.tbIteracao.Name = "tbIteracao";
            this.tbIteracao.Size = new System.Drawing.Size(305, 56);
            this.tbIteracao.TabIndex = 1;
            this.tbIteracao.Value = 5;
            this.tbIteracao.ValueChanged += new System.EventHandler(this.tbIteracao_ValueChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(654, 205);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 32);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1233, 281);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 530);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1233, 180);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 722);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxParticao);
            this.Controls.Add(this.gbxIntervalo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração Numérica";
            this.gbxIntervalo.ResumeLayout(false);
            this.gbxIntervalo.PerformLayout();
            this.gbxParticao.ResumeLayout(false);
            this.gbxParticao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVezes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIteracao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIntervalo;
        private System.Windows.Forms.TextBox txtIntervaloFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntervaloInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxParticao;
        private System.Windows.Forms.TextBox txtValorParticao;
        private System.Windows.Forms.TrackBar tbParticao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVezes;
        private System.Windows.Forms.TrackBar tbVezes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIteracao;
        private System.Windows.Forms.TrackBar tbIteracao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

