using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Tarefas.Models
{
    public class Todo
    {
        public Todo(string option)
        {
            this.option = option;
        }
        
        public string option = string.Empty;
        
        //Lista de tarefas;
        List<string> task = new List<string>();
        
        
        //Adiciona tarefas a lista;
        public void AddTask()
        {
            Console.WriteLine("==== Digite a tarefa que deseja adicionar: ====");
            task.Add(Console.ReadLine().ToUpper());
            Console.Clear();
        }

        //Lista as tarefas cadastradas;
        public void List()
        {
            Console.Clear();
            Console.WriteLine("==== Tarefas Adicionadas ====");

            int count = 1;
            foreach (string item in task)
            {
                Console.WriteLine($"Tarefa: {count} ==> {item}");
                count++;
            }
        }
        
        //Remove uma tarefa da lista;
        public void Remove()
        {
            Console.WriteLine("==== Digite a tarefa que deseja remover: ==== ");
            task.Remove(Console.ReadLine().ToUpper());
            Console.Clear();
        }
    }
}

     

       
       

        
            
            