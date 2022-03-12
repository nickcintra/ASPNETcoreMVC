using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //1-facil,2-médio, 3-difícil
        public byte Nivel { get; set; }
    }
}
