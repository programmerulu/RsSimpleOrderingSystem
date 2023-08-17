using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Storage: BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public bool IsSelling { get; set; }
    }
}
