using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimeraPractica
{
    internal class PokemonDataBase
    {
        public List<Pokemon> listar()
        {
			List<Pokemon> lista = new List<Pokemon>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server= .\\SQLEXPRESS; database= POKEDEX_DB; integrated security= true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select Numero, Nombre, Descripcion from POKEMONS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

                while (lector.Read())
                {
					Pokemon aux = new Pokemon();
					aux.Numero = lector.GetInt32(0); //Hace referencia a la linea 23
					aux.Nombre = (string)lector["Nombre"];
					aux.Descripcion = (string)lector["Descripcion"];

					lista.Add(aux);
                }
                return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				conexion.Close();
			}
        }
    }
}
