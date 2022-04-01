using System;

namespace ClassTask3.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            //InputFullName(out string fullname);
            //InputEmail(out string email);
            //InputPassword(out string password);
            string fullname = "";
            string email = "";
            string password = "";
            int studentLimit = 0;
            string groupNo = "";
            double point = 0;


            InputUser(ref fullname, ref email, ref password);
            User user = new User(fullname, email, password);
            Console.WriteLine(user.PasswordChecker(password));

            int key;
            do
            {
                Console.WriteLine("0.Quit");
                Console.WriteLine("1.Show info");
                Console.WriteLine("2. Create new group");
                Console.WriteLine("Reqem daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        break;
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("Grup melumatlarini qeyd edin");
                        InputGroupNo(ref groupNo);
                        Group g = new Group(groupNo, studentLimit);
                        Console.WriteLine(g.CheckGroupNo(groupNo));
                        InputStudentLimit(ref studentLimit);
                        break;
                    case 3:
                        Console.WriteLine("Student melumatlarin daxil dedin");
                        InputStudent(ref fullname, ref point);
                        Student stu1 = new Student(fullname, point);
                        g.AddStudent(stu1);
                        break;
                    default:
                        break;
                }
            } while (key!=0);
            do
            {
                Console.WriteLine("0.Quit");
                Console.WriteLine("1.Show all students");
                Console.WriteLine("2. Get student by id");
                Console.WriteLine("3. Add student");
                Console.WriteLine("Reqem daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        break;
                    case 1:
                        g.GetAllStudents();
                        break;
                    case 2:
                        int? studentId = null;
                        Console.WriteLine("Studentin idsin qeyd edin");
                        studentId = Convert.ToInt32(Console.ReadLine());
                        g.GetStudent(studentId);

                        break;
                    case 3:
                        InputFullName(out fullname);
                        InputStudentPoint(out double point);
                        Student student1 = new Student(fullname, point);
                        
                        break;
                    default:
                        break;
                }
            } while (key!=0);
        }
        static void InputUser(ref string fullname, ref string email, ref string password)
        {
            InputFullName(ref fullname);
            InputEmail(ref email);
            InputPassword(ref password);
        }
        static void InputFullName(ref string fullname)
        {
            Console.WriteLine("Ad daxil edin");
            fullname = Convert.ToString(Console.ReadLine());
        }
        static void InputPassword(ref string password)
        {
            Console.WriteLine("Sifre daxil edin");
            password = Convert.ToString(Console.ReadLine());
            User.PasswordChecker(password);
        }
        static void InputEmail(ref string email)
        {
            Console.WriteLine("Emaili daxil edin");
            email = Convert.ToString(Console.ReadLine());
        }
        static void InputPassword(ref string password)
        {
            do
            {
                Console.WriteLine("Password");
                password = Console.ReadLine();
                if (password == "false")
                {
                    Console.WriteLine("Parol yanlis daxil deildi");
                }
            } while (password == "false");

        }
        static void InputStudentLimit(ref int studentLimit)
        {
            do
            {
                Console.WriteLine("StudentLimit");
                studentLimit = Convert.ToInt32(Console.ReadLine());
                if (studentLimit < 5 && studentLimit > 18)
                {
                    Console.WriteLine("Limit asildi");
                }
            } while (studentLimit < 5 && studentLimit > 18);

        }
        static void InputGroupNo(ref string groupNo)
        {
            Console.WriteLine("GroupNo");
            groupNo = Console.ReadLine();
        }
        static void InputStudent(ref string fullname, ref double point)
        {
            InputstuFullname(ref fullname);
            InputPoint(ref point);
        }

        private static void InputPoint(ref double point)
        {
            Console.WriteLine("Student point");
            point = Convert.ToDouble(Console.ReadLine());
        }

        private static void InputstuFullname(ref string fullname)
        {
            Console.WriteLine("Fullname");
            fullname = Console.ReadLine();
        }


    }
}
