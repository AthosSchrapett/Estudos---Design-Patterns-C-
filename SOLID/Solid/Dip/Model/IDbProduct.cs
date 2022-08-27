using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    public interface IDbProduct
    {
        string GetProductById(string id);
    }
}
