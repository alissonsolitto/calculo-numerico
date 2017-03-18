namespace WindowsFormsApplication1
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtInicial = new System.Windows.Forms.TextBox();
            this.edtFinal = new System.Windows.Forms.TextBox();
            this.edtIntervalo = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.rcText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Raizes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 55);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 24;
            this.grd.Size = new System.Drawing.Size(767, 413);
            this.grd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ponto Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ponto Final:";
            // 
            // edtInicial
            // 
            this.edtInicial.Location = new System.Drawing.Point(106, 19);
            this.edtInicial.Name = "edtInicial";
            this.edtInicial.Size = new System.Drawing.Size(100, 22);
            this.edtInicial.TabIndex = 4;
            this.edtInicial.Text = "-1";
            // 
            // edtFinal
            // 
            this.edtFinal.Location = new System.Drawing.Point(325, 19);
            this.edtFinal.Name = "edtFinal";
            this.edtFinal.Size = new System.Drawing.Size(100, 22);
            this.edtFinal.TabIndex = 5;
            this.edtFinal.Text = "2";
            // 
            // edtIntervalo
            // 
            this.edtIntervalo.Location = new System.Drawing.Point(535, 19);
            this.edtIntervalo.Name = "edtIntervalo";
            this.edtIntervalo.Size = new System.Drawing.Size(100, 22);
            this.edtIntervalo.TabIndex = 7;
            this.edtIntervalo.Text = "0,1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(463, 22);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(66, 17);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Intervalo:";
            // 
            // rcText
            // 
            this.rcText.Location = new System.Drawing.Point(12, 468);
            this.rcText.Name = "rcText";
            this.rcText.Size = new System.Drawing.Size(767, 169);
            this.rcText.TabIndex = 8;
            this.rcText.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 649);
            this.Controls.Add(this.rcText);
            this.Controls.Add(this.edtIntervalo);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.edtFinal);
            this.Controls.Add(this.edtInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Dicotomia";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtInicial;
        private System.Windows.Forms.TextBox edtFinal;
        private System.Windows.Forms.TextBox edtIntervalo;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RichTextBox rcText;
    }
}

