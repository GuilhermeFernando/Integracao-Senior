namespace IntegracaoSenior
{
    partial class lbl_CodBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Reiniciar = new System.Windows.Forms.Button();
            this.bt_ConectarBanco = new System.Windows.Forms.Button();
            this.txt_StatusBanco = new System.Windows.Forms.TextBox();
            this.bt_CodBase = new System.Windows.Forms.Button();
            this.txt_CodBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(713, 415);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(75, 23);
            this.bt_Sair.TabIndex = 0;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Reiniciar
            // 
            this.bt_Reiniciar.Location = new System.Drawing.Point(713, 13);
            this.bt_Reiniciar.Name = "bt_Reiniciar";
            this.bt_Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.bt_Reiniciar.TabIndex = 1;
            this.bt_Reiniciar.Text = "Reiniciar";
            this.bt_Reiniciar.UseVisualStyleBackColor = true;
            this.bt_Reiniciar.Click += new System.EventHandler(this.bt_Reiniciar_Click);
            // 
            // bt_ConectarBanco
            // 
            this.bt_ConectarBanco.Location = new System.Drawing.Point(13, 12);
            this.bt_ConectarBanco.Name = "bt_ConectarBanco";
            this.bt_ConectarBanco.Size = new System.Drawing.Size(86, 23);
            this.bt_ConectarBanco.TabIndex = 2;
            this.bt_ConectarBanco.Text = "Conectar Banco de Dados";
            this.bt_ConectarBanco.UseVisualStyleBackColor = true;
            this.bt_ConectarBanco.Click += new System.EventHandler(this.bt_ConectarBanco_Click);
            // 
            // txt_StatusBanco
            // 
            this.txt_StatusBanco.Location = new System.Drawing.Point(105, 14);
            this.txt_StatusBanco.MaximumSize = new System.Drawing.Size(300, 2);
            this.txt_StatusBanco.Name = "txt_StatusBanco";
            this.txt_StatusBanco.Size = new System.Drawing.Size(167, 20);
            this.txt_StatusBanco.TabIndex = 3;
            // 
            // bt_CodBase
            // 
            this.bt_CodBase.Location = new System.Drawing.Point(13, 82);
            this.bt_CodBase.Name = "bt_CodBase";
            this.bt_CodBase.Size = new System.Drawing.Size(86, 23);
            this.bt_CodBase.TabIndex = 4;
            this.bt_CodBase.Text = "Codigo Base";
            this.bt_CodBase.UseVisualStyleBackColor = true;
            this.bt_CodBase.Click += new System.EventHandler(this.bt_CodBase_Click);
            // 
            // txt_CodBase
            // 
            this.txt_CodBase.Location = new System.Drawing.Point(105, 84);
            this.txt_CodBase.Name = "txt_CodBase";
            this.txt_CodBase.Size = new System.Drawing.Size(167, 20);
            this.txt_CodBase.TabIndex = 5;
            // 
            // lbl_CodBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_CodBase);
            this.Controls.Add(this.bt_CodBase);
            this.Controls.Add(this.txt_StatusBanco);
            this.Controls.Add(this.bt_ConectarBanco);
            this.Controls.Add(this.bt_Reiniciar);
            this.Controls.Add(this.bt_Sair);
            this.Name = "lbl_CodBase";
            this.Text = "Integracao Senior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Reiniciar;
        private System.Windows.Forms.Button bt_ConectarBanco;
        private System.Windows.Forms.TextBox txt_StatusBanco;
        private System.Windows.Forms.Button bt_CodBase;
        private System.Windows.Forms.TextBox txt_CodBase;
    }
}

