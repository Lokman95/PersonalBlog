using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPDOTNETBOLMVC6.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Categories { get; set; }
    }
}
