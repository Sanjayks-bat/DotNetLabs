using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class ToDo
    {
        public string Name { get; set; }

        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }

        public bool IsCompleted { get; set; }

        private ToDo[] _toDos = new ToDo[10];

        
        public void ViewTodos()
        {
            foreach (var singleTodo in _toDos)
            {
                if(singleTodo!= null) {
                    Console.WriteLine($"Name: {singleTodo.Name} |" + $"Started on: {singleTodo.StartDate} |" + $"Ended on: {singleTodo.EndDate} |" + $"Is Completed: {singleTodo.IsCompleted}");
                }
               
            }
        }
        public void ViewTodos(string pName)
        {
            foreach (var singleTodos in _toDos)
            {
                if(singleTodos.Name == pName)
                {
                    Console.WriteLine($"Name: {singleTodos.Name} |" +$"Started on: {singleTodos.StartDate} |" +$"Ended on: {singleTodos.EndDate} |" +
                    $"Is Completed: {singleTodos.IsCompleted} ");
                    break;
                }
                
            }
        }

        public void Create(int pPosition)
        {
            if (pPosition > 9)
            {
                throw new Exception("Pleae enter value between 0-9");
            }
            _toDos[pPosition] = new ToDo() { Name = this.Name, StartDate = this.StartDate, EndDate = this.EndDate, IsCompleted = this.IsCompleted };
            Console.WriteLine("Todo created successfully!");
        }

        public void Edit()
        {

        }


        public void Delete()
        {

        }
    }
}
