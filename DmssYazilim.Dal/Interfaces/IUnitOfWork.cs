using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmssYazilim.Dal.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T: class//reposıtorıden gelen taleplerı database e ıletecegız
    {
        IRepository<T> Rep { get; }//repoya ulaşmak ıcın tanımlıyoruz
        bool Save();
    }
}
