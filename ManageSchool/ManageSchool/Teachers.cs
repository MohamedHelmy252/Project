using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSchool
{

    internal class Teachers : Person
    {
        public Teachers(string _Name, int _Id, int _Age) : base(_Name, _Id, _Age)
        {

        }

         static List<Teachers>  listTeacher = new List<Teachers>();


        public static void AddMemberTeacher()
        {
            string Name;
            int Age;
            int Id; 



            Console.Write("Enter Number Of Teacher:");
            bool Flag = int.TryParse(Console.ReadLine(),out int Size);
            if (Flag is true && Size > 0)
            {
                try
                {
                    for (int i = 0; i < Size; i++)
                    {

                        Console.WriteLine($"Teacher [{i + 1}]");
                        Console.Write("Enter  Name : ");
                        Name = Console.ReadLine();
                        Console.Write("Enter   Age : ");
                        Age = int.Parse(Console.ReadLine());
                        Console.Write("Ente     Id : ");
                        Id = int.Parse(Console.ReadLine());
                        listTeacher.Add(new Teachers(Name, Id, Age));
                     Console.WriteLine("Added successfully");
                        // Console.Clear();
                    }
                }
               catch (Exception e) { Console.WriteLine("Enter correct value."); }





            }
            else
            {
                Console.WriteLine("Enter Correct Input!");
            }



            }
        public static void Show()
        {
            if (listTeacher.Count == 0)
            {
                Console.WriteLine("No students to display.");
            }
            else
            {
                foreach (var item in listTeacher)
                {
                    Console.WriteLine($"Name: {item.Name}  Age: {item.Age}  Id: {item.Id}");
                }
            }

        }
        public static void Search(string _Name)
        {
            int Index=-1;
            if (listTeacher.Count > 0)
            {
                for (int i = 0;i < listTeacher.Count;i++)
                {


                    if (listTeacher[i].Name == _Name)
                    {

                        Index = i;
                    }
          
                }
                if (Index != -1)
                {
                    Console.WriteLine($"Name: {listTeacher[Index].Name}  Age: {listTeacher[Index].Age}  Id: {listTeacher[Index].Id}");
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }
               
            }
            else
            {
                Console.WriteLine("List Is Empty !");
            }
        }
        public static void Delete(string _Name)
        {
            int Index = -1;
            if (listTeacher.Count > 0)
            {
                for (int i = 0; i < listTeacher.Count; i++)
                {


                    if (listTeacher[i].Name == _Name)
                    {

                        Index = i;
                    }

                }
                if (Index != -1)
                {
                    Console.WriteLine($"{listTeacher[Index].Name} : Deleted");
                    listTeacher.Remove(listTeacher[Index]);
                }
                else
                {
                    Console.WriteLine("Not Found!");
                }

            }
            else
            {
                Console.WriteLine("List Is Empty!");
            }
      
        }
    }

        


    
}
