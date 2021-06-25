using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using SistemasCarros.Web.Models;


namespace SistemasCarros.Web.DAO
{
    public class CarroDAO
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public void Insert(Carro carro)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("INSERT INTO tb_carro () VALUES ();", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Carro> SelectAll()
        {
            var resultado = new List<Carro>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("SELECT * FROM tb_carro;", connection))
                {
                    connection.Open();
                    var resultadoQuery = command.ExecuteReader();

                    if (resultadoQuery.HasRows)
                    {
                        while (resultadoQuery.Read())
                        {
                            resultado.Add(new Carro() 
                            {
                                Codigo = int.Parse(resultadoQuery["Codigo"].ToString()),
                                CodigoMarca = int.Parse(resultadoQuery["CodigoMarca"].ToString()),
                                Ano = int.Parse(resultadoQuery["Ano"].ToString()),
                                Modelo = resultadoQuery["Modelo"].ToString(),
                                Cor = resultadoQuery["Cor"].ToString()
                            });
                        }
                    }
                }

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Carro>();
            }
        }

        public void Update(Carro carro)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("UPDATE tb_carro SET {} WHERE ", connection))
                {
                    connection.Open();
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
                using (var command = new SqlCommand($"DELETE FROM tb_carro WHERE Codigo = {codigo};", connection))
                {
                    connection.Open();
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