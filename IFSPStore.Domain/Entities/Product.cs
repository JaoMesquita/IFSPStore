using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {

        public Product(int id, string nome, double preco, int quantidade, DateTime dataCompra, string unidadeVenda, int idGrupo):base(id)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            UnidadeVenda = unidadeVenda;
            IdGrupo = idGrupo;
        }

        public int id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public string UnidadeVenda { get; set; }
        public int IdGrupo { get; set; }

    }
}
