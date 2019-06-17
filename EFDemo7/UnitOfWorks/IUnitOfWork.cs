using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo7.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        // Başka operasyonlar da tanımlanabilir. 
        // void OpenTransaction(); 
        // void CloseTransaction(); 
        // gibi 
    }
}
