using System.ComponentModel.DataAnnotations;

namespace mindmapGPT_server.Entity
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Role {  get; set; }
    }
}
