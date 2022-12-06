using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class WorkInProgress
    {
        public int WorkInProgressId { get; set; }

        public string EditorId { get; set; } = null!;

        public int IsBeingWorkedOnId { get; set; }
    }
}
