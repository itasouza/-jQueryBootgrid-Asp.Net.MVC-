using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Web.BootGrid.Models
{
    public class Livro
    {
        [Key]
        public int idlivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoEdicao { get; set; }
        public decimal Valor { get; set; }

        public Genero Genero { get; set; }
        public int idgenero { get; set; }
    }
}