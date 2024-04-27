using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_II.Interfaces
{
    internal interface IBuilderQuery
    {
        void setSelect(string select);
        void setFrom(string from);
        void setWhere(string where);
        void setGroupBy(string groupBy);
        void setOrderBy(string orderBy);
    }
}
