namespace EmpClassLib
{
    public abstract class Person
    {
       /* public int Age { get; set; }
         public string Name { get; set; }

         public Person( string name, int age)
         {
             Name = name;
             Age = age;
         }*/

        public abstract void Leave();

        public virtual void AssignLeave()
        {
            Console.WriteLine("You Can't take leave!");
        }
    }
}