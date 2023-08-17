using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Consumer : BaseEntity,IEntity
    {
        public string ConsumerName { get; set; }
        public string ConsumerSurname { get; set; }
        public string ConsumerPhoneNumber { get; set; }
        public string ConsumerEMail { get; set; }
        public string ConsumerGender { get; set; }
        public string ConsumerPassword { get; set; }
        public int ConsumerTitleId { get; set; }
    }

}
