using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZcrlMedicamentModels
{
    public class MedicamentRemain
    {
        public int Id { get; set; }

        public virtual Medicament Medicament { get; set; }
        public int MedicamentId { get; set; }

        public virtual HospitalDepartment Department { get; set; }
        public int HospitalDepartmentId { get; set; }

        public decimal CurrentRemain { get; set; }

        public DateTime UpdateDate { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MedicamentRemain castedObj = obj as MedicamentRemain;

            if (castedObj == null)
                return false;

            return Id == castedObj.Id;
        }
    }
}
