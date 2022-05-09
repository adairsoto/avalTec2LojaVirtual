namespace LojaOnline.Telas
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstProdCliente = new System.Windows.Forms.ListBox();
            this.btnExibirProd = new System.Windows.Forms.Button();
            this.btnAddCarr = new System.Windows.Forms.Button();
            this.txtQtdCarr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIrCarr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstProdCliente
            // 
            this.lstProdCliente.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdCliente.FormattingEnabled = true;
            this.lstProdCliente.ItemHeight = 21;
            this.lstProdCliente.Location = new System.Drawing.Point(12, 110);
            this.lstProdCliente.Name = "lstProdCliente";
            this.lstProdCliente.Size = new System.Drawing.Size(568, 235);
            this.lstProdCliente.TabIndex = 1;
            // 
            // btnExibirProd
            // 
            this.btnExibirProd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirProd.Location = new System.Drawing.Point(225, 43);
            this.btnExibirProd.Name = "btnExibirProd";
            this.btnExibirProd.Size = new System.Drawing.Size(145, 46);
            this.btnExibirProd.TabIndex = 2;
            this.btnExibirProd.Text = "Exibir Produtos";
            this.btnExibirProd.UseVisualStyleBackColor = true;
            this.btnExibirProd.Click += new System.EventHandler(this.btnExibirProd_Click);
            // 
            // btnAddCarr
            // 
            this.btnAddCarr.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarr.Location = new System.Drawing.Point(590, 211);
            this.btnAddCarr.Name = "btnAddCarr";
            this.btnAddCarr.Size = new System.Drawing.Size(180, 38);
            this.btnAddCarr.TabIndex = 3;
            this.btnAddCarr.Text = "Adicionar ao Carrinho";
            this.btnAddCarr.UseVisualStyleBackColor = true;
            this.btnAddCarr.Click += new System.EventHandler(this.btnAddCarr_Click);
            // 
            // txtQtdCarr
            // 
            this.txtQtdCarr.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdCarr.Location = new System.Drawing.Point(620, 146);
            this.txtQtdCarr.Name = "txtQtdCarr";
            this.txtQtdCarr.Size = new System.Drawing.Size(99, 28);
            this.txtQtdCarr.TabIndex = 4;
            this.txtQtdCarr.Text = "1";
            this.txtQtdCarr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe a Quantidade";
            // 
            // btnIrCarr
            // 
            this.btnIrCarr.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCarr.Location = new System.Drawing.Point(590, 292);
            this.btnIrCarr.Name = "btnIrCarr";
            this.btnIrCarr.Size = new System.Drawing.Size(180, 37);
            this.btnIrCarr.TabIndex = 6;
            this.btnIrCarr.Text = "Ir Para o Carrinho";
            this.btnIrCarr.UseVisualStyleBackColor = true;
            this.btnIrCarr.Click += new System.EventHandler(this.btnIrCarr_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 433);
            this.Controls.Add(this.btnIrCarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdCarr);
            this.Controls.Add(this.btnAddCarr);
            this.Controls.Add(this.btnExibirProd);
            this.Controls.Add(this.lstProdCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstProdCliente;
        private System.Windows.Forms.Button btnExibirProd;
        private System.Windows.Forms.Button btnAddCarr;
        private System.Windows.Forms.TextBox txtQtdCarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIrCarr;
    }
}