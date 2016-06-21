using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Core.Interfaces
{
    interface IContextHelper<T>
    {
        bool Insert<T>(T row) where T : class;
        bool Update<T>(T row) where T : class;
        bool Delete<T>(T row) where T : class;
        bool AddRows<T>(T[] rows) where T : class;
    }
}
