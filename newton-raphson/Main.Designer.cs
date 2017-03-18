namespace WindowsFormsApplication2
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
            this.rcText = new System.Windows.Forms.RichTextBox();
            this.edtInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // rcText
            // 
            this.rcText.Location = new System.Drawing.Point(12, 459);
            this.rcText.Name = "rcText";
            this.rcText.Size = new System.Drawing.Size(767, 169);
            this.rcText.TabIndex = 17;
            this.rcText.Text = "";
            // 
            // edtInicial
            // 
            this.edtInicial.Location = new System.Drawing.Point(106, 10);
            this.edtInicial.Name = "edtInicial";
            this.edtInicial.Size = new System.Drawing.Size(100, 22);
            this.edtInicial.TabIndex = 13;
            this.edtInicial.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ponto Inicial:";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 46);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 24;
            this.grd.Size = new System.Drawing.Size(767, 413);
            this.grd.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular Raizes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 637);
            this.Controls.Add(this.rcText);
            this.Controls.Add(this.edtInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Newton Raphson";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rcText;
        private System.Windows.Forms.TextBox edtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button button1;
    }
}

