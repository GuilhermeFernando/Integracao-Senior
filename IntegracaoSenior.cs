using System;
using System.Data.SqlClient;
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

        private void bt_ConectarBanco_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Usuario;User Id=sa;Password=123456;MultipleActiveResultSets=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    txt_StatusBanco.Text = "Conectado!";
                    txt_StatusBanco.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex) 
            {
                txt_StatusBanco.Text = ex.Message;
                txt_StatusBanco.ForeColor= System.Drawing.Color.Red;
            }
        }

        private void bt_CodBase_Click(object sender, EventArgs e)
        {
            string CodigoBase = txt_CodBase.Text;
        }
    }

}
