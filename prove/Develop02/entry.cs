using System;

public class entry
{
    public string _message  = "";
    public string _response= "";
    public string _date = DateTime.Now.ToString("dd-MM-yyyy");

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_message}");
        //Convert the fist letter of the string _resonse to capital letter
        Console.WriteLine(char.ToUpper(_response[0]) + _response.Substring(1));
    }
}