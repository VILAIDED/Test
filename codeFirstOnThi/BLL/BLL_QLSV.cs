using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codeFirstOnThi.DAL;
using codeFirstOnThi.DTO;
namespace codeFirstOnThi.BLL
{
    class BLL_QLSV
    {
        private static BLL_QLSV _Instance;
        private delegate int CompareSV(SV s1, SV s2);
        public static BLL_QLSV Instance
        {
            get
            {
                if(_Instance == null)
                {
                    return _Instance = new BLL_QLSV();
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
        private BLL_QLSV()
        {

        }
        public List<SV> GetListSV_BLL(string name,int idLop)
        {
            List<SV> svList = new List<SV>();
            if("".Equals(name) && idLop == 0)
            {
                svList = DAL_QLSV.Instance.GetAllSV_DAL();

            }
            else
            {
                if(idLop == 0)
                {
                    foreach(SV sv in DAL_QLSV.Instance.GetAllSV_DAL())
                    {
                        if (sv.NameSV.ToUpper().Contains(name.ToUpper()))
                        {
                            svList.Add(sv);
                        }
                    }
                }
                else
                {
                    foreach (SV sv in DAL_QLSV.Instance.GetAllSV_DAL())
                    {
                        if (sv.NameSV.ToUpper().Contains(name.ToUpper()) && sv.IdLop == idLop)
                        {
                            svList.Add(sv);
                        }
                    }
                }
            }
            return svList;
        }
        public List<CBBItems> GetCBBItems_BLL()
        {
            List<CBBItems> cbbList = new List<CBBItems>();
            foreach(LSH lsh in DAL_QLSV.Instance.GetAllLSH_DAL())
            {
                cbbList.Add(new CBBItems
                {
                    Value = lsh.IdLop,
                    Text = lsh.NameLop
                });
            }
            return cbbList;
        }
        public void DelSV_BLL(List<string> mssvList)
        {
            foreach(string mssv in mssvList)
            {
                DAL_QLSV.Instance.DelSV_DAL(mssv);
            }
        }
        public void ExecuteSV(SV sv)
        {
            if (DAL_QLSV.Instance.SvIsExist_DAL(sv.MSSV))
            {
                DAL_QLSV.Instance.EditSV_DAL(sv);
            }
            else
            {
                DAL_QLSV.Instance.AddSV_DAL(sv);
            }
        }
        public List<SV> SortListSV(int idLop,string name,string sortBy)
        {
            List<SV> data = GetListSV_BLL(name, idLop);
            CompareSV cmp;
            switch (sortBy) {
                case "MSSV":
                    {
                        cmp = SV.CmpMSSV;
                        break;
                    }
                case "NS":
                    cmp = SV.CmpNS;
                    break;
                case "MaLop":
                    cmp = SV.CmpIdLop;
                    break;
                case "HoTen":
                    cmp = SV.CmpNameSV;
                    break;
                default:
                    cmp = SV.CmpIdLop;
                    break;
            }
            SV tmp = new SV();
            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data.Count; j++)
                {
                    Console.WriteLine(cmp(data[i], data[j]));
                    if(cmp(data[i],data[j]) < 0)
                    {
                        tmp = data[i];
                        data[i] = data[j];
                        data[j] = tmp;
                    }
                }
            }
            return data;
        }
        public SV GetSvByMSSV_BLL(string mssv)
        {
            return DAL_QLSV.Instance.GetSVByMSSV_DAL(mssv);
        }

    }
}
