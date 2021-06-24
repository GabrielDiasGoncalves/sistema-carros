using SistemasCarros.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemasCarros.Web.DAO
{
    public class MarcaDAO
    {
        private string _connectionString;

        public MarcaDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Insert(Marca marca)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("INSERT INTO tb_marca () VALUES ();", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Marca> SelectAll()
        {
            var resultado = new List<Marca>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("SELECT * FROM tb_marca;", connection))
                {
                    var resultadoQuery = command.ExecuteReader();

                    if (resultadoQuery.HasRows)
                    {
                        while (resultadoQuery.Read())
                        {
                            resultado.Add(new Marca()
                            {
                                Codigo = int.Parse(resultadoQuery["Codigo"].ToString()),
                                Nome = resultadoQuery["Nome"].ToString()
                            });
                        }
                    }
                }

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Marca>();
            }
        }

        public void Update(Marca marca)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("UPDATE tb_marca SET {} WHERE ", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(int codigo)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand($"DELETE FROM tb_marca WHERE Codigo = {codigo};", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}