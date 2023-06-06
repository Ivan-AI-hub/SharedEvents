using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedEvents.Models
{
    public class DoctorDeleted
    {
        public Guid Id { get; set; }

        public DoctorDeleted(Guid id)
        {
            Id = id;
        }
    }
}
