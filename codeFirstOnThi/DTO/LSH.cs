using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace codeFirstOnThi.DTO
{
    [Table("LSH")]
    public  class LSH
    {
        public LSH()
        {
            SVs = new HashSet<SV>();
        }
        [Key]
        public int IdLop { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }

    }
}
