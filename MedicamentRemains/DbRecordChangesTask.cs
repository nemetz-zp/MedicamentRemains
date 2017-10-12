using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZcrlMedicamentModels;

namespace MedicamentRemains
{
    public enum DbRecordChangesType
    {
        Create,
        Update,
        Remove
    }

    public class DbRecordChangesTask
    {
        public object DbRecord { get; set; }
        public DbRecordChangesType ChangesType { get; set; }
    }
}
