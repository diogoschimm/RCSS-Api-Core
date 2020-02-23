using System.Collections.Generic;
using System.Linq;

namespace RCSS.AppServices.Dtos
{
    public class ModelTableService<T> : RetornoService where T : class
    {
        public List<T> Lista { get; set; }

        public int Count
        {
            get
            {
                if (this.Lista != null)
                    return this.Lista.Count();
                return 0;
            }
        }
    }
}
