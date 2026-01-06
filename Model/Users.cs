using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Role
    {
        User = 0,
        Employee = 1,
        Manager = 2,
        Upper_Manager = 3
    }
    public class Users : BaseEntity
    {
        private string username;
        private string email;
        private string passkey;
        private Role role;

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Passkey { get => passkey; set => passkey = value; }
        public Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"User: Id = {Id}, Username = {Username}, Email = {Email}, Role = {Role}";
        }
    }
}
