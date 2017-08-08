namespace CadastroPersonagens
{
    partial class formCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btResetar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.listCadastrados = new System.Windows.Forms.ListBox();
            this.btCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 26);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(12, 176);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(210, 26);
            this.txtTipo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arma";
            // 
            // txtArma
            // 
            this.txtArma.Location = new System.Drawing.Point(12, 255);
            this.txtArma.Name = "txtArma";
            this.txtArma.Size = new System.Drawing.Size(210, 26);
            this.txtArma.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ataque";
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(12, 332);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(85, 26);
            this.txtAtaque.TabIndex = 6;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Black;
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btNovo.Location = new System.Drawing.Point(12, 398);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(108, 39);
            this.btNovo.TabIndex = 8;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btApagar
            // 
            this.btApagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btApagar.Location = new System.Drawing.Point(204, 398);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(108, 39);
            this.btApagar.TabIndex = 9;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = false;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btResetar
            // 
            this.btResetar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btResetar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btResetar.Location = new System.Drawing.Point(381, 398);
            this.btResetar.Name = "btResetar";
            this.btResetar.Size = new System.Drawing.Size(108, 39);
            this.btResetar.TabIndex = 10;
            this.btResetar.Text = "Resetar";
            this.btResetar.UseVisualStyleBackColor = false;
            this.btResetar.Click += new System.EventHandler(this.btResetar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(138, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defesa";
            // 
            // txtDefesa
            // 
            this.txtDefesa.Location = new System.Drawing.Point(137, 332);
            this.txtDefesa.Name = "txtDefesa";
            this.txtDefesa.Size = new System.Drawing.Size(85, 26);
            this.txtDefesa.TabIndex = 7;
            this.txtDefesa.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbID.Location = new System.Drawing.Point(95, 22);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 23);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // picImagem
            // 
            this.picImagem.Image = global::CadastroPersonagens.Properties.Resources.GettyImages_134367495;
            this.picImagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImagem.InitialImage")));
            this.picImagem.Location = new System.Drawing.Point(526, 92);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(250, 345);
            this.picImagem.TabIndex = 16;
            this.picImagem.TabStop = false;
            // 
            // listCadastrados
            // 
            this.listCadastrados.BackColor = System.Drawing.Color.DarkGray;
            this.listCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCadastrados.FormattingEnabled = true;
            this.listCadastrados.ItemHeight = 23;
            this.listCadastrados.Location = new System.Drawing.Point(301, 92);
            this.listCadastrados.Name = "listCadastrados";
            this.listCadastrados.Size = new System.Drawing.Size(162, 255);
            this.listCadastrados.TabIndex = 18;
            this.listCadastrados.SelectedIndexChanged += new System.EventHandler(this.listCadastrados_SelectedIndexChanged_1);
            // 
            // btCarregar
            // 
            this.btCarregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCarregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCarregar.Location = new System.Drawing.Point(526, 14);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(162, 39);
            this.btCarregar.TabIndex = 11;
            this.btCarregar.Text = "Carregar Imagem...";
            this.btCarregar.UseVisualStyleBackColor = false;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroPersonagens.Properties.Resources.dark_25;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.listCadastrados);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDefesa);
            this.Controls.Add(this.btResetar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAtaque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "formCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.formCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtaque;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btResetar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ListBox listCadastrados;
        private System.Windows.Forms.Button btCarregar;
    }
}

