using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosAcoes
{
    public class ClassDB
    {
        private SqlConnection conexao;
        public SqlConnection connection()
        {
            conexao = new SqlConnection("Data Source=DESKTOP-SEACM7B;Initial Catalog=dbUser;Integrated Security=True");
            return conexao;
        }


        public void Registrar(string usuario, string senha )
        {
            try{
                SqlConnection b = connection();
                SqlCommand command = new SqlCommand("Insert into tbClient (Usuario,Senha)values(@USUARIO,@SENHA)",b);
                command.Parameters.AddWithValue("@USUARIO", usuario);
                command.Parameters.AddWithValue("@SENHA", senha );
                b.Open();
        
                command.ExecuteNonQuery();
                b.Close();
            }
            catch(Exception e)
            {
               Console.WriteLine(e.Message);
                throw;
            }
          

        }


        public DataTable SelectTudo()
        {
            DataTable tbclient = new DataTable() ;
            try
            {
                SqlConnection db = connection();
                
                SqlCommand command = new SqlCommand("Select * from tbClient",db);                
                db.Open();
                command.ExecuteReader();
                db.Close();
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(tbclient);

                return tbclient;

            }catch(Exception e)
            {
                throw;
            }
        }

    }
}
