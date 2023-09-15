using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace TIENDA
{
    class Produtos
    {
        OleDbConnection conector;
        OleDbCommand comando;
        string sql = "";

        public Produtos()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=TIENDA.mdb");
            comando = new OleDbCommand();

        }
        public void grabar(int produto, string nombre, int stock)
        {
            sql = $"INSERT INTO productos VALUES({produto}, '{nombre}', {stock})"; 
            conector.Open();
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql; 
            comando.ExecuteNonQuery();
            


            conector.Close(); 
        } 
        public void listar(DataGridView grilla)
        {
            sql = "SELECT * FROM productos ORDER BY nombre"; //WHERE stock>100
            conector.Open();
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            OleDbDataReader dr = comando.ExecuteReader();
            grilla.Rows.Clear(); 
            while (dr.Read()) 
            {
                grilla.Rows.Add(dr["producto"], dr["nombre"], dr["stock"]);

            }
        }
        public void eliminar(int producto)
        {
            sql = $"DELETE FROM productos WHERE producto = {producto}";
            conector.Open();
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            conector.Close();
        }
    }
}
