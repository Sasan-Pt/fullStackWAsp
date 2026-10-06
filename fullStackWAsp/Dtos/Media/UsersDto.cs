using fullStackWAsp.Classes;
using fullStackWAsp.enums;

namespace fullStackWAsp.Dtos.Media
{
    public class UsersDto: BaseEntity
    {
        public required string Email { get; set; }
        public required string Username { get; set; }

        public required string  Password_hash { get; set; }
        public Role Role { get; set; }


    }
}
