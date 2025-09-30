using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {
        public Customer(int id, string nome, string endereco, string documento, string bairro, string cidade, int IdCidade, City city) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
            Bairro = bairro;
            Cidade = cidade;
            IdCidade = idCidade;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int idCidade { get; set; }

    }
}
