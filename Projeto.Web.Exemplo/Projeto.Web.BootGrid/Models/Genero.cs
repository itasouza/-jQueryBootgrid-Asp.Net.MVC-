using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Web.BootGrid.Models
{
    public class Genero
    {
        [Key]
        public int idgenero { get; set; }
        public string Nome { get; set; }
    }
}