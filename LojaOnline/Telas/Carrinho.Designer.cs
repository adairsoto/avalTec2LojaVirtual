namespace LojaOnline.Telas
{
    partial class Carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            this.lstCarr = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.lblProd2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinCompra = new System.Windows.Forms.Button();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCarr
            // 
            this.lstCarr.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarr.FormattingEnabled = true;
            this.lstCarr.ItemHeight = 21;
            this.lstCarr.Location = new System.Drawing.Point(-1, 38);
            this.lstCarr.Name = "lstCarr";
            this.lstCarr.Size = new System.Drawing.Size(540, 172);
            this.lstCarr.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(587, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forma de Pagamento";
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd1.Location = new System.Drawing.Point(45, 322);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(0, 27);
            this.lblProd1.TabIndex = 3;
            // 
            // lblProd2
            // 
            this.lblProd2.AutoSize = true;
            this.lblProd2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd2.Location = new System.Drawing.Point(45, 349);
            this.lblProd2.Name = "lblProd2";
            this.lblProd2.Size = new System.Drawing.Size(0, 27);
            this.lblProd2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dados da Compra";
            // 
            // btnFinCompra
            // 
            this.btnFinCompra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinCompra.Location = new System.Drawing.Point(577, 143);
            this.btnFinCompra.Name = "btnFinCompra";
            this.btnFinCompra.Size = new System.Drawing.Size(142, 32);
            this.btnFinCompra.TabIndex = 6;
            this.btnFinCompra.Text = "Finalizar Compra";
            this.btnFinCompra.UseVisualStyleBackColor = true;
            this.btnFinCompra.Click += new System.EventHandler(this.btnFinCompra_Click);
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPag.Location = new System.Drawing.Point(348, 322);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(0, 27);
            this.lblFormaPag.TabIndex = 7;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(348, 349);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 27);
            this.lblValorTotal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 444);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 424);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.btnFinCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProd2);
            this.Controls.Add(this.lblProd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstCarr);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.Carrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.Label lblProd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinCompra;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}