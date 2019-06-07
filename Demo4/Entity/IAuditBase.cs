using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity
{
    interface IAuditEntity
    {
        string CreateBy { get; set; }
        DateTime CreateDate { get; set; }

        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
