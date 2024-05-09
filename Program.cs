using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Tarefas.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;


string option = string.Empty;
Todo list = new Todo(option);


bool isRunning = true;
while(isRunning)
{
    
    string[] menu = 
        [
        " ==== MENU ====",
        "1- Adicionar Tarefa",
        "2- Listar tarefas cadastradas",
        "3- Remover tarefa",
        "4- Encerrar programa"
        ]; 

         foreach (string item in menu)
         {
            Console.WriteLine(item);
         }
         Console.WriteLine("Digite a opção desejada e pressione ENTER:");

    option = Console.ReadLine().ToUpper();

    switch (option)
    {
        case "1":
            list.AddTask();
        break;

        case "2":
            list.List();
        break;
            
        case "3":
            list.Remove();
        break;

        case "4":
            isRunning = false;
        break;
            
        default:
            Console.WriteLine(" ==== Opção Inválida ====");
        break;
    }
    Console.WriteLine("==== Pressione ENTER para continuar ====");
    Console.ReadLine();
}
            
            
            

    
    

            


    