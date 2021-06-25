using SistemasCarros.Web.Models;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemasCarros.Web.DAO
{
    public class MarcaDAO
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public string Insert(Marca marca)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand($"INSERT INTO tb_marca (Nome) OUTPUT Inserted.Codigo VALUES ('{marca.Nome}');", connection))
                {
                    connection.Open();
                    var id = (int)command.ExecuteScalar();
                    return $"Marca inserida: {id}";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Erro ao inserir uma nova marca, favor conferir todos os campos";
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
                    connection.Open();
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
                using (var command = new SqlCommand($"DELETE FROM tb_marca WHERE Codigo = {codigo};", connection))
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