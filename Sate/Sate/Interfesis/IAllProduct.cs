using Sate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sate.Interfesis
{
    public interface IAllProduct
    {
        IEnumerable<Product> Products { get; }

    }
}
