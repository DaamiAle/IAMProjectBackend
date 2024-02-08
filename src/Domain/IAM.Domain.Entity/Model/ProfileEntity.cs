using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAM.Domain.Entity.Model;

public class ProfileEntity
{
    public int Id { get; set; }
    public string XMLProfile { get; set; }
    [Required]
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public UserEntity User { get; set; }
    public bool RegState { get; set; }
}
