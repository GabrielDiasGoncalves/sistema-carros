using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemasCarros.Web.Models
{
    public class Carro
    {
        public int Codigo { get; set; }
        public int CodigoMarca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; } // único campo não obrigatório
    }
}