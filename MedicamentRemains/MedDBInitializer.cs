using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MedicamentRemains
{
    public class MedDBInitializer : CreateDatabaseIfNotExists<MedicamentRemainsContext>
    {
        protected override void Seed(MedicamentRemainsContext context)
        {
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Поліклінічне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Терапевтичне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Кардіо-неврологічне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Гінекологічне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Дитяче відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Хірургічне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Урологічне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Інфекційне відділення" });
            context.HospitalDepartments.Add(new ZcrlMedicamentModels.HospitalDepartment { Name = "Стоматологічне відділення" });
            context.SaveChanges();

            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "амп." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "гр." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "капс." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "м" });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "пара" });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "таб." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "уп." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "фл." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "шт." });
            context.Meters.Add(new ZcrlMedicamentModels.Meter { Name = "шприц-ручка" });
            context.SaveChanges();

            context.MedicamentsGroups.Add(new ZcrlMedicamentModels.MedicamentGroup { Name = "Медикаменти загального призначення", ViewPriority = 0 });
            context.MedicamentsGroups.Add(new ZcrlMedicamentModels.MedicamentGroup { Name = "Цукропонижуючі засоби", ViewPriority = 1 });
            context.MedicamentsGroups.Add(new ZcrlMedicamentModels.MedicamentGroup { Name = "Імуносупрессори", ViewPriority = 2 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
