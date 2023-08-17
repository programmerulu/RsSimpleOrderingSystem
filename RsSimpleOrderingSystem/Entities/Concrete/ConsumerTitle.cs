using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ConsumerTitle: BaseEntity, IEntity
    {
        public int ConsumerId { get; set; }
        public int TitleId { get; set; }
    }
}
