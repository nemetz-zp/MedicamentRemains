using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZcrlMedicamentModels
{
    public class Meter
    {
        public int Id { get; set; }
        public string Name { get; set; }
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

            Meter castedObj = obj as Meter;

            if (castedObj == null)
                return false;

            return Id == castedObj.Id;
        }
    }
}
