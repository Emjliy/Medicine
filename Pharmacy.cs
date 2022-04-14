using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Pharmacy
    {
        public int MedicineLimit { get; set; }
        List<Medicine> medList = new List<Medicine>();
        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
        }
        public void AddMedicine(Medicine med)
        {
            bool isExist = false;
            foreach (var item in medList)
            {
                if (item.Name == med.Name)
                {
                    isExist = true;
                    throw new MedicineAlreadyExistException("This Medicine Name is already exist");
                }
            }
            if (!isExist)
            {
                if (medList.Count <= MedicineLimit)
                {
                    medList.Add(med);
                }
                else
                {
                    throw new CapacityLimitException("Capacity is exceed");
                }

            }
        }

        public void GetAllMedicine()
        {

            List<Medicine> copyOfMyList = new List<Medicine>();

            copyOfMyList.AddRange(medList);
            foreach (var item in medList)
            {
                copyOfMyList.Add(item);
                Console.WriteLine(item.Name + " " + item.Price + " " + item.Count);
            }
            foreach (var sitem in copyOfMyList)
            {
                sitem.isDeleted = false;
            }
        }
        public void FilterMedicinesByPrice(int minPrice, int maxPrice)
        {
            foreach (var item in medList)
            {
                if (minPrice < item.Price && item.Price < maxPrice)
                {
                    Console.WriteLine($"Bu araligdaki prices:{item}");
                }

            }


        }
        public void GetAllMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id is null");
            }
            else
            {
                foreach (var item in medList)
                {
                    if (item.Id == id && item.isDeleted == false)
                    {
                        Console.Write(item.Id + " " + item.Name);
                    }
                }


            }

        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id is null");
            }
            else
            {
                bool isExist = false;
                foreach (var item in medList)
                {
                    if (item.Id == id && item.isDeleted == false)
                    {
                        isExist = true;
                        item.isDeleted = true;
                        Console.Write($"Deleted- {item.Id } {item.Name} ");
                    }
                }
                if (!isExist)
                {
                    throw new NotFoundException("This Id is not exist in Medicine");
                }

            }


        }
        public void EditMedicineEmail(int? id, string name)
        {
            if (id == null && name == null)
            {
                throw new NullReferenceException("Id and Name is null");
            }
            else
            {
                bool isExist = false;
                foreach (var item in medList)
                {
                    if (item.Id == id || item.isDeleted == false)
                    {
                        isExist = true;
                        item.Name = name;
                        Console.Write($"- {item.Id } {item.Name} ");
                    }

                }
                if (!isExist)
                {
                    throw new NotFoundException("This Id is not exist in Medicine");
                }

            }
        }
    }
}
