using System;

namespace Task4_creat_class1
{

    class Program
    { 
        static void Main(string[] args)
        { 
           Console.WriteLine("Plz ent num Of Employee");
           //---------
           int num =int.Parse(Console.ReadLine());string input;string[] input_Split; 
           Employee[] employee=new Employee[num];Employee searched_Employee;//string chosse="";
           //----------

           
           for (int i = 0; i <num; i++)
           {
               employee[i]=new Employee(i+1);
           }

           while (true)
           {
             Console.WriteLine(" Search About Employee\n ");
             input=Console.ReadLine();
             input_Split=input.Split(",");
             
             searched_Employee=Functions.giveMeSearch(employee ,input_Split[0],input_Split[1]);
             if(searched_Employee!=null) 
              {
                Console.WriteLine("-----------------------");
                Console.WriteLine("id :"+searched_Employee.id);
                Console.WriteLine("name :"+searched_Employee.name);
                Console.WriteLine("Age :"+searched_Employee.age);
                Console.WriteLine("department :"+searched_Employee.department);
                Console.WriteLine("-----------------------\n");
             }

             else { Console.WriteLine("Sorry::Not Found\n");}
            }
   
        }
    }
}
