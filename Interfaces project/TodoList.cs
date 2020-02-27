using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      if (Todos.Length <= 5)
      {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
      }
      else
      {
        Console.WriteLine("Too many items in To-do list!");
      }
    }
    
    public void Display()
    {
      Console.WriteLine("To-do list:");
      foreach (string todo in Todos)
      {
        if (String.IsNullOrEmpty(todo) == true)
        {
          Console.WriteLine("[ ]");
        }
        else
        {
        Console.WriteLine(todo);
        }
      }
      Console.WriteLine("\n");
    }
    
    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
    
    
  }
}