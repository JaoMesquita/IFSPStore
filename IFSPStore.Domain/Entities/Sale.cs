using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime dataVenda, double valorTotal, int idUsuario, int idCliente) : base(id)
        {
            Id = id;
            DataVenda = dataVenda;
            ValorTotal = valorTotal;
            IdUsuario = idUsuario;
            IdCliente = idCliente;
        }

        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotal { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }

    }

}
