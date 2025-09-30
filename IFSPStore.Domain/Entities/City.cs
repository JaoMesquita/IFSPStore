using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class City : BaseEntity<int>
    {
        public City(int id, string nome, string estado):base(id){
            Nome = nome;
            Estado = estado;
        }

        public string Nome { get; set; }
        public string Estado { get; set; }

    }
}
 
