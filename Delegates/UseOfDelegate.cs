using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class UseOfDelegate
    {
        static void Main()
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee() { ID = 1, Name = "Sourav", Sal = 5000, Exp = 5 });
            lst.Add(new Employee() { ID = 2, Name = "Atanu", Sal = 3000, Exp = 2 });
            lst.Add(new Employee() { ID = 3, Name = "Debonil", Sal = 4000, Exp = 7 });
            lst.Add(new Employee() { ID = 4, Name = "Deep", Sal = 6000, Exp = 3 }); // Conflicted comment in VS
            lst.Add(new Employee() { ID = 5, Name = "Mimo", Sal = 6000, Exp = 3 }); //Added in VS new branch
            lst.Add(new Employee() { ID = 6, Name = "Shanu", Sal = 6000, Exp = 3 }); //Added in remote location
            //Employee.getPromotion(lst);
            //Promotion del = new Promotion(Employee.getPromotion);
            //del(lst);
            //IsPromotable del = new IsPromotable(condition);
            //Employee.getPromotion(lst,del);
            Employee.getPromotion(lst, x => x.Exp >= 5);
        }
        //public static bool condition(Employee emp)
        //{
        //    if (emp.Exp >= 5)
        //        return true;
        //    else
        //        return false;
        //}
    }

    //delegate void Promotion(List<Employee> emplst);
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
        public int Exp { get; set; }

        public static void getPromotion(List<Employee> emplist, IsPromotable isPromotable)
        {
            foreach(Employee emp in emplist)
            {
                //if(emp.Exp>=5)
                if (isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted.");
                }
            }
            Console.ReadLine();
        } 
    }
}
