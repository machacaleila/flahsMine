using System;
using System.Collections.Generic;
using System.Text; 
using System.IO;

public class Journal
{
    
    public List<Entry> _save = new List<Entry>();
    public string _fileName;
    
    public void DisplayQuestions(){
        Entry answer = new Entry();
        Random questions = new Random();
        int x = questions.Next(5);
        string[] array = new string[5];
        array[0] = "Who was the most interesting person I interacted with today?";
        array[1] = "What was the best part of my day?";
        array[2] = "How did I see the hand of the Lord in my life today?";
        array[3] = "What was the strongest emotion I felt today?";
        array[4] = "If I had one thing I could do over today, what would it be?";
        answer._prompt = (array[x]);
        Console.WriteLine(array[x]);  
        answer._userResponse = Console.ReadLine();
        _save.Add(answer); //Agrego a la lista la respuesta del ususario.
    }

    public void ShowAnswers(){
        foreach (Entry respuesta in _save){
           respuesta.DisplayEntries();
        }

    }
    
    public void DisplayJournal(){
       using (StreamWriter outputFile = new StreamWriter(Console.ReadLine()))//nombre del arhivo by user.
        {
           foreach (Entry respuesta in _save)//primero hay que guardar cada linea del entry en el archivo txt
          {
               //Crear una instance para la respuesta.
               outputFile.WriteLine($"Date: {respuesta._theCurrentTime} - Prompt: {respuesta._prompt} - {respuesta._userResponse}");//lo primero que copio en el archivo. 
               
          }
        }

    }

    public void loadText(){
         Console.Write("What is this file name? ");
         string name = Console.ReadLine();
         string[] lines = System.IO.File.ReadAllLines(name);
         _save = new List<Entry>();//aca resetee
        foreach (string line in lines) 
           {
              var entry = new Entry();//llamar
              string[] parts = line.Split(':', '-');//Split picar en partes la linea y guardar cada parte en una array.
              entry._theCurrentTime = parts[1];
              entry._prompt= parts[3];
              entry._userResponse = parts[4];
              _save.Add(entry);
              Console.WriteLine($"Date: {entry._theCurrentTime} - Prompt: {entry._prompt} \n {entry._userResponse}");

             }
        
    }
}