using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ZcrlMedicamentModels
{
    public class MedicamentContext :  DbContext
    {
        public MedicamentContext(string conString) : base(conString) { }

        public DbSet<MedicamentRemain> MedicamentRemains { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<HospitalDepartment> HospitalDepartments { get; set; }
        public DbSet<Meter> Meters { get; set; }
        public DbSet<MedicamentGroup> MedicamentsGroups { get; set; }
    }
}
