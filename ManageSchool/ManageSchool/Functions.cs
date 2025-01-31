using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSchool
{
    internal class Functions
    {








        public static void AddMemberStuden(string str, Action TeacherFuncDelegate)
        {
            bool flag;
            string Name;
            int Age;
            int Id;

            Console.Write($"Enter Number of {str}: ");
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
                        Console.Write("Enter Age: ");
                        Age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Id: ");
                        Id = int.Parse(Console.ReadLine());

                        // إضافة الطالب إلى القائمة
                        TeacherFuncDelegate.Invoke();
                        Console.Clear();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter correct value.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter correct size!");
            }





        }
    }
}
