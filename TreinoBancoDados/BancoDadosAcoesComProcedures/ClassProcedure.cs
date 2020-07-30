using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosAcoesComProcedures
{
    public class ClassProcedure
    {
        private SqlConnection conexao;

        public SqlConnection connection()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString);

            return conexao;
        }

        public DataTable SelectBanco()
        {

            SqlCommand cmd = new SqlCommand("pSelectTbClient", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            conexao.Open();
            dt.Load(cmd.ExecuteReader());
            conexao.Close();
            return dt;
        }


        public void InseritBanco()
        {
            SqlCommand cmd = new SqlCommand("pInsertTbClient", connection());
            cmd.CommandType = CommandType.StoredProcedure;
            
        }
    }
}
