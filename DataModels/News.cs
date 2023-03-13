using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.DataModels
{
    [PrimaryKey(nameof(NewsId))]
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewsId { get; set; }
        public string NewsReport { get; set; }
    }
}
