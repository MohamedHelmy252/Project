namespace ManageSchool
{
    internal class Start
    {
        public static void StartProgram()
        {
            do
            {
                Console.WriteLine("______________________");
                Console.WriteLine("| Manage Ment school |");
                Console.WriteLine("----------------------");
                Console.WriteLine("Add Teacher Click [1]");
                Console.WriteLine("Add Student Click [2]");
                Console.WriteLine("Show  Data  Click [3]");
                Console.WriteLine("Search[Name]Click [4]");
                Console.WriteLine("Delete[Name]Click [5]");
                Console.WriteLine("Exit        Click [6]");
                Console.WriteLine("---------------------");

                bool flag = int.TryParse(Console.ReadLine(), out int operation);

                if (flag && operation >= 1)
                {
                    switch (operation)
                    {
                        case 1:
                            Teachers.AddMemberTeacher();
                            break;
                        case 2:
                            Students.AddMemberStuden();
                         
                            break;
                        case 3:
                            Console.WriteLine("To View The List Of Teacher  Click [1]");
                            Console.WriteLine("To View The List Of Students Click [2]");

                            bool Flag = int.TryParse(Console.ReadLine(), out int option);
                            if (flag is true && (option == 1) || option == 2)
                            {
                                if (option == 1)
                                {
                                    Teachers.Show();
                                }
                                else
                                {
                                    Students.Show();
                                }

                            }
                         
                            break;
                        case 4:
                            Console.WriteLine("To View The Data Of Teacher  Click [1]");
                            Console.WriteLine("To View The Data Of Student  Click [2]");

                            bool Flag2 = int.TryParse(Console.ReadLine(), out int option2);
                            if (flag is true && (option2 == 1) || option2 == 2)
                            {

                                if (option2 == 1)
                                {
                                    Console.Write("Enter Name Of Student : ");
                                    string Name = Console.ReadLine();
                                    Teachers.Search(Name);
                                }
                                else
                                {
                                    Console.Write("Enter Name Of Student : ");
                                    string Name = Console.ReadLine();
                                    Students.Search(Name);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Enter Valid Inpt Only Number [1 OR 2] !");
                            }

                            break;
                        case 5:
                            Console.WriteLine("To Delete The Data Of Teacher  Click [1]");
                            Console.WriteLine("To Delete The Data Of Student  Click [2]");

                            bool Flag3 = int.TryParse(Console.ReadLine(), out int option3);
                            if (flag is true && (option3 == 1) || option3 == 2)
                            {

                                if (option3 == 1)
                                {
                                    Console.Write("Enter Name Of Student : ");
                                    string Name = Console.ReadLine();
                                    Teachers.Delete(Name);
                                }
                                else
                                {
                                    Console.Write("Enter Name Of Student : ");
                                    string Name = Console.ReadLine();
                                    Students.Delete(Name); 

                                }

                            }
                            else
                            {
                                Console.WriteLine("Enter Valid Inpt Only Number [1 OR 2] !");
                            }
                            break;
                        case 6:
                            return;
                            break;
                        default:
                            Console.WriteLine("Choose only from these values [1-6]!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Choose only from these values [1-6]!");
                }
             
            } while (true);
        }
    }
}