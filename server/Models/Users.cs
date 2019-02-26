using System.Collections.Generic;

namespace Server.Models
{
    public class User
    {
        public int Id { get; set;}
        public string Email { get; set; }
        public byte[]  Salt { get; set; }
        public byte[] PasswordHash { get; set; }
        public virtual ICollection<Movies> Movies { get; set;}

    }
}