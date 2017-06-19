using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Dominio
{
   public class TB_LIVRO
    {
       public int idlivro { get; set; }
       public string Titulo { get; set; }
       public string Autor { get; set; }
       public int AnoEdicao { get; set; }
       public decimal Valor { get; set; }
      
       public TB_GENERO Genero { get; set; }
       public int idgenero { get; set; }
    }
}
