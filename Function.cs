using System;
namespace Task4_creat_class1
{ 
    class Functions
    { 
    public static Employee  giveMeSearch(Employee[] employee,string fild ,string value )
         { 
           
            if(fild=="name"||fild=="Name")
            {
               foreach (Employee item in employee)
               {
                  if(item.name==value) { return item; }
               }
             
            }
            else if(fild=="department"||fild=="Department")
            {
               foreach (Employee item in employee)
               {
                  if(item.department==value) {  return item;}
               }
             
            }
            else if(fild=="id"||fild=="Id")
            {   
               int value_Ascii_Converted=0;

               foreach (char c in value)
               {
                value_Ascii_Converted+=(System.Convert.ToInt32(c)-48);
               }
               foreach (Employee item in employee)
               {
                  if(item.id==value_Ascii_Converted) {  return item;}
               }
               
            }
            else if(fild=="age"||fild=="Age")
            {   
               int value_Ascii_Converted=0;

               foreach (char c in value)
               {
                value_Ascii_Converted+=(System.Convert.ToInt32(c)-48);
               }
               foreach (Employee item in employee)
               {
                   if(item.age==value_Ascii_Converted) {  return item;}
               }

            }
            return null;
         }
    }
}