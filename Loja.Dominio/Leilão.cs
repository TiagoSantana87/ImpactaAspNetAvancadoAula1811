using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Dominio
{
    class Leilao
    {
        public int Id { get; set; }

        public string NomeLote { get; set; }

        public List<Produto> Produtos { get; set; }

        public List<string> Validar()
        {
            var erros = new List<string>();


            return erros;
        }
    }
}
