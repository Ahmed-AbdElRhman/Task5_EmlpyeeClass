using System;
using System.Reflection;

namespace Task4_creat_class1
{ 
    class Functions
    { 
    public static Employee  giveMeSearch(Employee[] employee,string fild ,string value )
         { 
            //---------
            int index=0;
            Type t=Type.GetType("Task4_creat_class1.Employee");
            PropertyInfo[] properties=t.GetProperties();
            //---------

            foreach (PropertyInfo property in properties)
            {
               if(property.Name==fild) {break;}
               index++; 
               
            }
            if(index<properties.Length)
            {
               
               for (int i = 0; i < employee.Length; i++)
               {
                      if ((properties[index].GetValue(employee[i]).ToString())==value){return employee[i];}
               }
            }

            return null;
           
         }
    }
}