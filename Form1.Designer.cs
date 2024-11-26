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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_CodBase = new System.Windows.Forms.TextBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insira Codigo Base SAP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_CodBase
            // 
            this.txt_CodBase.Location = new System.Drawing.Point(204, 138);
            this.txt_CodBase.Name = "txt_CodBase";
            this.txt_CodBase.Size = new System.Drawing.Size(100, 20);
            this.txt_CodBase.TabIndex = 3;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(35, 15);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(132, 23);
            this.btn_Conectar.TabIndex = 4;
            this.btn_Conectar.Text = "Conectar Banco";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.Location = new System.Drawing.Point(173, 15);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(161, 20);
            this.lbl_Status.TabIndex = 5;
            // 
            // lbl_CodBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.txt_CodBase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Reiniciar);
            this.Controls.Add(this.bt_Sair);
            this.Name = "lbl_CodBase";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Reiniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_CodBase;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.TextBox lbl_Status;
    }
}

