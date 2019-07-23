namespace Task4_creat_class1
{
     public class Employee
    {  
        
        public int id { get  ; set ;}
        public int age{ get  ; set ;}
        public string  name{ get  ; set ;}
        public string  department{ get  ; set ;}
   //_____________________Constractors_________________________________________

        public Employee(){}
        public Employee(int i)
        {
            this.id=i;
            this.age=i;
            this.name="name"+i;
            this.department="department"+i;
        }
    }
}