namespace AggiungiProdotto
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
            this.prezzo = new System.Windows.Forms.Label();
            this.tbx_prezzo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_anno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.cbx_brand = new System.Windows.Forms.ComboBox();
            this.cbx_categoria = new System.Windows.Forms.ComboBox();
            this.btn_carica_prodotto = new System.Windows.Forms.Button();
            this.btn_carica_lista = new System.Windows.Forms.Button();
            this.dgr_lista_prodotti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_lista_prodotti)).BeginInit();
            this.SuspendLayout();
            // 
            // prezzo
            // 
            this.prezzo.AutoSize = true;
            this.prezzo.Location = new System.Drawing.Point(339, 119);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(58, 20);
            this.prezzo.TabIndex = 23;
            this.prezzo.Text = "Prezzo";
            // 
            // tbx_prezzo
            // 
            this.tbx_prezzo.Location = new System.Drawing.Point(339, 166);
            this.tbx_prezzo.Name = "tbx_prezzo";
            this.tbx_prezzo.Size = new System.Drawing.Size(276, 26);
            this.tbx_prezzo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Anno Modello";
            // 
            // tbx_anno
            // 
            this.tbx_anno.Location = new System.Drawing.Point(36, 166);
            this.tbx_anno.Name = "tbx_anno";
            this.tbx_anno.Size = new System.Drawing.Size(276, 26);
            this.tbx_anno.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome Prodotto";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(35, 77);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(276, 26);
            this.tbx_nome.TabIndex = 14;
            // 
            // cbx_brand
            // 
            this.cbx_brand.FormattingEnabled = true;
            this.cbx_brand.Location = new System.Drawing.Point(339, 77);
            this.cbx_brand.Name = "cbx_brand";
            this.cbx_brand.Size = new System.Drawing.Size(276, 28);
            this.cbx_brand.TabIndex = 26;
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.Location = new System.Drawing.Point(644, 75);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(276, 28);
            this.cbx_categoria.TabIndex = 27;
            // 
            // btn_carica_prodotto
            // 
            this.btn_carica_prodotto.Location = new System.Drawing.Point(971, 73);
            this.btn_carica_prodotto.Name = "btn_carica_prodotto";
            this.btn_carica_prodotto.Size = new System.Drawing.Size(204, 118);
            this.btn_carica_prodotto.TabIndex = 28;
            this.btn_carica_prodotto.Text = "Carica Nuovo Prodotto";
            this.btn_carica_prodotto.UseVisualStyleBackColor = true;
            this.btn_carica_prodotto.Click += new System.EventHandler(this.btn_carica_prodotto_Click);
            // 
            // btn_carica_lista
            // 
            this.btn_carica_lista.Location = new System.Drawing.Point(384, 248);
            this.btn_carica_lista.Name = "btn_carica_lista";
            this.btn_carica_lista.Size = new System.Drawing.Size(439, 33);
            this.btn_carica_lista.TabIndex = 30;
            this.btn_carica_lista.Text = "Aggiorna Lista Prodotti";
            this.btn_carica_lista.UseVisualStyleBackColor = true;
            this.btn_carica_lista.Click += new System.EventHandler(this.btn_carica_lista_Click);
            // 
            // dgr_lista_prodotti
            // 
            this.dgr_lista_prodotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_lista_prodotti.Location = new System.Drawing.Point(56, 301);
            this.dgr_lista_prodotti.Name = "dgr_lista_prodotti";
            this.dgr_lista_prodotti.RowHeadersWidth = 62;
            this.dgr_lista_prodotti.RowTemplate.Height = 28;
            this.dgr_lista_prodotti.Size = new System.Drawing.Size(1080, 137);
            this.dgr_lista_prodotti.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 450);
            this.Controls.Add(this.btn_carica_lista);
            this.Controls.Add(this.dgr_lista_prodotti);
            this.Controls.Add(this.btn_carica_prodotto);
            this.Controls.Add(this.cbx_categoria);
            this.Controls.Add(this.cbx_brand);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.tbx_prezzo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_anno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_lista_prodotti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prezzo;
        private System.Windows.Forms.TextBox tbx_prezzo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_anno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.ComboBox cbx_brand;
        private System.Windows.Forms.ComboBox cbx_categoria;
        private System.Windows.Forms.Button btn_carica_prodotto;
        private System.Windows.Forms.Button btn_carica_lista;
        private System.Windows.Forms.DataGridView dgr_lista_prodotti;
    }
}

