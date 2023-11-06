using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanBooks.DataAccess.Repository.IRepository
{
    public interface  ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurename, DynamicParameters parm = null);
        T OneRecord<T>(string procedurename, DynamicParameters parm = null);
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
