using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoSenior
{
    public partial class lbl_CodBase : Form
    {
        public lbl_CodBase()
        {
            InitializeComponent();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Reiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // String de conexão ao banco de dados
            string connectionString = "Server=localhost;Database=Usuario;User Id=sa;Password=123456;MultipleActiveResultSets=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    connection.Open();
                    lbl_Status.Text = "Conexão bem-sucedida!";
                    lbl_Status.ForeColor = System.Drawing.Color.Green; // Mostra mensagem em verde
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro
                lbl_Status.Text = $"Erro: {ex.Message}";
                lbl_Status.ForeColor = System.Drawing.Color.Red; // Mostra mensagem em vermelho
            }

        }
    }
}
