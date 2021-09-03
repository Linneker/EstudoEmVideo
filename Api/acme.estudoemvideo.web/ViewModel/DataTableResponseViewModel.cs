using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.ViewModel
{
    public class DataTableResponseViewModel<TEntity> where TEntity : class
    {
        public List<TEntity> data { get; set; }
    }
}
