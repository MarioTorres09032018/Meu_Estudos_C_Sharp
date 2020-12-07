namespace Primeiro_App_Teste
{
    partial class Form1
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
            this.BtnNome = new System.Windows.Forms.Button();
            this.BtnDescricao = new System.Windows.Forms.Button();
            this.BtnNumeroSerie = new System.Windows.Forms.Button();
            this.BtnFabricante = new System.Windows.Forms.Button();
            this.BtnNumeroPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNome
            // 
            this.BtnNome.Location = new System.Drawing.Point(12, 50);
            this.BtnNome.Name = "BtnNome";
            this.BtnNome.Size = new System.Drawing.Size(99, 32);
            this.BtnNome.TabIndex = 2;
            this.BtnNome.UseVisualStyleBackColor = true;
            // 
            // BtnDescricao
            // 
            this.BtnDescricao.Location = new System.Drawing.Point(12, 88);
            this.BtnDescricao.Name = "BtnDescricao";
            this.BtnDescricao.Size = new System.Drawing.Size(99, 32);
            this.BtnDescricao.TabIndex = 3;
            this.BtnDescricao.Text = "Descrição";
            this.BtnDescricao.UseVisualStyleBackColor = true;
            // 
            // BtnNumeroSerie
            // 
            this.BtnNumeroSerie.Location = new System.Drawing.Point(12, 126);
            this.BtnNumeroSerie.Name = "BtnNumeroSerie";
            this.BtnNumeroSerie.Size = new System.Drawing.Size(99, 32);
            this.BtnNumeroSerie.TabIndex = 4;
            this.BtnNumeroSerie.Text = "Número de Série";
            this.BtnNumeroSerie.UseVisualStyleBackColor = true;
            // 
            // BtnFabricante
            // 
            this.BtnFabricante.Location = new System.Drawing.Point(12, 164);
            this.BtnFabricante.Name = "BtnFabricante";
            this.BtnFabricante.Size = new System.Drawing.Size(99, 32);
            this.BtnFabricante.TabIndex = 5;
            this.BtnFabricante.Text = "Fabricante";
            this.BtnFabricante.UseVisualStyleBackColor = true;
            // 
            // BtnNumeroPedido
            // 
            this.BtnNumeroPedido.Location = new System.Drawing.Point(12, 202);
            this.BtnNumeroPedido.Name = "BtnNumeroPedido";
            this.BtnNumeroPedido.Size = new System.Drawing.Size(99, 32);
            this.BtnNumeroPedido.TabIndex = 6;
            this.BtnNumeroPedido.Text = "Número Pedido";
            this.BtnNumeroPedido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 17);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnValor
            // 
            this.BtnValor.Location = new System.Drawing.Point(12, 12);
            this.BtnValor.Name = "BtnValor";
            this.BtnValor.Size = new System.Drawing.Size(99, 32);
            this.BtnValor.TabIndex = 0;
            this.BtnValor.Text = "CARROS ";
            this.BtnValor.UseVisualStyleBackColor = true;
            this.BtnValor.Click += new System.EventHandler(this.BtnValor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNumeroPedido);
            this.Controls.Add(this.BtnFabricante);
            this.Controls.Add(this.BtnNumeroSerie);
            this.Controls.Add(this.BtnDescricao);
            this.Controls.Add(this.BtnNome);
            this.Controls.Add(this.BtnValor);
            this.Name = "Form1";
            this.Text = "TABELA DE PREÇOS DE CARROS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNome;
        private System.Windows.Forms.Button BtnDescricao;
        private System.Windows.Forms.Button BtnNumeroSerie;
        private System.Windows.Forms.Button BtnFabricante;
        private System.Windows.Forms.Button BtnNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnValor;
    }
}

