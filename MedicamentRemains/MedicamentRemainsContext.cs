using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ZcrlMedicamentModels;

namespace MedicamentRemains
{
    public class MedicamentRemainsContext : MedicamentContext
    {
        static MedicamentRemainsContext()
        {
            Database.SetInitializer<MedicamentRemainsContext>(new MedDBInitializer());
        }

        public MedicamentRemainsContext() : base("cnStr") { }
    }
}
