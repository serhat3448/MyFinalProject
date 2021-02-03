using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interface metotları default olarak publictir ama kendisi default olarak public değildir.
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
