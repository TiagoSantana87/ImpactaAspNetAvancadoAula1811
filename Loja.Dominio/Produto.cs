using System;

namespace Loja.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        // virtual - ligar o lazy load.
        public virtual Categoria Categoria { get; set; }
        public virtual ProdutoImagem Imagem { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }
        public bool EmLeilao { get; set; }

        internal static object Sum()
        {
            throw new NotImplementedException();
        }

        internal static object Sum(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}