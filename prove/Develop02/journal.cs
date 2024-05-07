using System;
using System.Collections.Generic;

public class Journal{

    public string _name = "";

    public List<entry> _entries = new List<entry>();
    
    public void Display()
    {
        Console.WriteLine($"Name: "+char.ToUpper(_name[0]) + _name.Substring(1));

        
        Console.WriteLine($"Entries:");

        
        //Display all the jobs(information for each element) in the list _jobs
        foreach (entry elementEntry in _entries)
        {
         //Display all the information inside the element
         elementEntry.Display();
         
        }
    }

    }