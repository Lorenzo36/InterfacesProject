using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }
    
    public void Display()
    {
      if (Hidden == false)
      {
        Console.WriteLine($"Password: {Password}");
      }
      else 
      {
        Console.WriteLine("*****HIDDEN*****");
      }
    }
    
    public void Reset()
    {
      string Password = null;
      Hidden = false;
    }
    
    
  }
}