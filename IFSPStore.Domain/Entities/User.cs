using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User(int id, string name, string password, string login, string email, DateTime regDate, DateTime loginDate):base(id)
        {
            Id = id;
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegDate = regDate;
            LoginDate = loginDate;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime LoginDate { get; set; }

    }
}
