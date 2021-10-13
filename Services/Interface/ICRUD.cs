using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICRUD<T>
    {
        void InitData();
        IEnumerable<T> GetAll();
        bool Creat(T data);
        bool Update(T data);
        bool Delete(T data);
    }
}
