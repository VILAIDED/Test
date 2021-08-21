using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace codeFirstOnThi.DTO
{
    [Table("SinhVien")]
    public class SV
    {
        [Key]
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public SV()
        {
            NS = new DateTime(2000,1,1);
        }
        public int IdLop { get; set; }
        [ForeignKey("IdLop")]
        public virtual LSH LSHs { get; set; }
        public static int CmpMSSV(SV s1,SV s2)
        {
            return Convert.ToInt32(s1.MSSV).CompareTo(Convert.ToInt32(s2.MSSV));
        }
        public static int CmpNameSV(SV s1,SV s2)
        {
            return s1.NameSV.CompareTo(s2.NameSV);
        }
        public static int CmpNS(SV s1,SV s2)
        {
            return s1.NS.CompareTo(s2.NS);
        }
        public static int CmpIdLop(SV s1,SV s2)
        {
            return s1.IdLop.CompareTo(s2.IdLop);
        }
    }
}
