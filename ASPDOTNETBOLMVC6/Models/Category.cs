using ASPDOTNETBOLMVC6.Repository.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPDOTNETBOLMVC6.Models
{
    public class Category:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
    }
}
