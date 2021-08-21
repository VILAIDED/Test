using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codeFirstOnThi.DTO;
namespace codeFirstOnThi.DAL
{
    class DAL_QLSV
    {
        private QLSV context = new QLSV();
        private static DAL_QLSV _Instance;
        public static DAL_QLSV Instance
        {
            get
            {
                if(_Instance == null)
                {
                    return _Instance = new DAL_QLSV();
                }
                else
                {
                    return _Instance;
                }
            }
            set
            {

            }
        }
        private DAL_QLSV()
        {

        }
        public List<SV> GetAllSV_DAL()
        {
            return context.SVs.ToList();
        }
        public List<LSH> GetAllLSH_DAL()
        {
            return context.LSHs.ToList();
        }
        public void DelSV_DAL(string mssv)
        {
            SV tmp = context.SVs.Find(mssv);
            context.SVs.Remove(tmp);
            context.SaveChanges();

        }
        public void AddSV_DAL(SV sv)
        {
            context.SVs.Add(sv);
            context.SaveChanges();
        }
        public void EditSV_DAL(SV sv)
        {
            SV tmp = context.SVs.Find(sv.MSSV);
            tmp = sv;
            context.SaveChanges();
        }
        public bool SvIsExist_DAL(string mssv)
        {
            return context.SVs.Where(s => s.MSSV == mssv).Count() > 0 ? true : false;
        }
        public SV GetSVByMSSV_DAL(string mssv)
        {
            SV sv = context.SVs.Find(mssv);
            return sv;
        }
    }
}
