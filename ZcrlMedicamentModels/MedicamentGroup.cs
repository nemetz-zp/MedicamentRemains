using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZcrlMedicamentModels
{
    public class MedicamentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ViewPriority { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MedicamentGroup castedObj = obj as MedicamentGroup;

            if (castedObj == null)
                return false;

            return Id == castedObj.Id;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
