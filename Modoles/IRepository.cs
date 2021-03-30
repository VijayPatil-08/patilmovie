using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movievijay.Modoles
{
    public interface IRepository<t>
    {
        public IEnumerable<t> GetItems();

        public t GetItemById(int id);

        public void AddItem(t t);
    }
}
