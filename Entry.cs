using System;
using System.Collections;
using System.Text; 
using System.IO;

public class Entry
{
    public string _userResponse;
        
    public string _theCurrentTime = DateTime.Now.ToShortDateString(); 
    public string _prompt;
    public void DisplayEntries(){
        Console.WriteLine($"Date: {_theCurrentTime} - Prompt: {_prompt} \n{_userResponse}");
    }

}