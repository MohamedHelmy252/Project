using System.Data;

namespace ManageSchool
{
    internal class Students : Person
    {
        public static List<Students> listStudent = new List<Students>();

   
        public Students(string _Name, int _Age, int _Id) : base(_Name, _Age, _Id)
        {
        }

      
        public static void AddStudent(string Name, int Age, int Id)
        {
            listStudent.Add(new Students(Name, Age, Id));
        }
        public static void Show()
        {
            if (listStudent.Count == 0)
            {
                Console.WriteLine("No students to display.");
            }
            else
            {
                foreach (var item in listStudent)
                {
                    Console.WriteLine($"Name: {item.Name}  Age: {item.Age}  Id: {item.Id}");
                }
            }
          
        }
        public static void Search(string _Name)
        {
            int Index = -1;
            if (listStudent.Count > 0)
            {
                for (int i = 0; i < listStudent.Count; i++)
                {


                    if (listStudent[i].Name == _Name)
                    {

                        Index = i;
                    }

                }
                if (Index != -1)
                {
                    Console.WriteLine($"Name: {listStudent[Index].Name}  Age: {listStudent[Index].Age}  Id: {listStudent[Index].Id}");
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
        public static void AddMemberStuden()
        {
            bool flag;
            string Name;
            int Age;
            int Id;

            Console.Write($"Enter Number of Students: ");
            flag = int.TryParse(Console.ReadLine(), out int Size);
            if (flag && Size >= 1)
            {
                for (int i = 0; i < Size; i++)
                {
                    try
                    {
                        Console.WriteLine($"Student [{i + 1}]");
                        Console.Write("Enter Name: ");
                        Name = Console.ReadLine();
                        Console.Write("Enter  Age: ");
                        Age = int.Parse(Console.ReadLine());
                        Console.Write("Enter   Id: ");
                        Id = int.Parse(Console.ReadLine());

                       
                        AddStudent(Name, Age, Id);
                        Console.WriteLine("Added successfully");
                      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter correct value.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Correct Input!");
            }
        }
        public static void Delete(string _Name)
        {
            int Index = -1;
            if (listStudent.Count > 0)
            {
                for (int i = 0; i < listStudent.Count; i++)
                {


                    if (listStudent[i].Name == _Name)
                    {

                        Index = i;
                    }

                }
                if (Index != -1)
                {
                    Console.WriteLine($"{listStudent[Index].Name} : Deleted");
                    listStudent.Remove(listStudent[Index]);
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
