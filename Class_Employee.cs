namespace Task4_creat_class1
{
     public class Employee
    {  
        
        public int id ;
        public int age;
        public string  name;
        public string  department;
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