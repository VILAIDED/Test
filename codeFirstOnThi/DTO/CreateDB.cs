using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace codeFirstOnThi.DTO
{
    class CreateDB : CreateDatabaseIfNotExists<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            base.Seed(context);
            context.LSHs.AddRange(new LSH[]
            {
                new LSH { IdLop = 101, NameLop = "19TCLC_DT1"},
                new LSH { IdLop = 102, NameLop = "19TCLC_DT2"},
                new LSH { IdLop = 103, NameLop = "19TCLC_DT3"},
                new LSH { IdLop = 104, NameLop = "19TCLC_DT4"},
                new LSH { IdLop = 105, NameLop = "19TCLC_DT5"}
            }); 
        }
    }
}
