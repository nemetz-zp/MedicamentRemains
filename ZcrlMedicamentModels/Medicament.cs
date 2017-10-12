using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZcrlMedicamentModels
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual Meter Meter { get; set; }
        public int MeterId { get; set; }

        public virtual MedicamentGroup Group { get; set; }
        public int MedicamentGroupId { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Medicament castedObj = obj as Medicament;

            if (castedObj == null)
                return false;

            return Id == castedObj.Id;
        }
    }
}
