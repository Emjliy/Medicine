using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medd = new Medicine("Phar",20,5,false);
            Medicine medd1 = new Medicine("Pharmas",25,12,false);
            Pharmacy pharm = new Pharmacy(3);
            pharm.AddMedicine(medd);
            pharm.AddMedicine(medd1);
            pharm.GetAllMedicine();
            //pharm.GetAllMedicineById(1);
            //pharm.GetAllMedicineById(2);
            pharm.DeleteMedicineById(1);
            pharm.DeleteMedicineById(2);
            pharm.EditMedicineEmail(0, "");
        }
    }
}
