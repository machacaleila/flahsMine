using System;
using System.Collections.Generic;
using System.Data;
class Program
{
    static void Main(string[] args){
          
        Journal load = new Journal();
//I am going to make the questions here.
        List<string> menu = new List<string>();//Create the list menu
        menu.Add("1.Write");
        menu.Add("2.Display");
        menu.Add("3.Load");
        menu.Add("4.Save");
        menu.Add("5.Quit");
        //Print the whole menu
        
        Console.WriteLine("Welcome to the journal Program!");
//Use loop to stop the menu and sking to continue
        int rule = 5;
        while (rule != 10)
         {
            Console.WriteLine("Please select one of the next choices to start: ");
            foreach (string items in menu){
               Console.WriteLine(items);
             }
        
             Console.Write("What would you like to do?:  ");
             rule = int.Parse(Console.ReadLine());
             if (rule == 1){
               load.DisplayQuestions();
                  
             }
             else if (rule == 2){
                load.ShowAnswers();
               
             }
             else if (rule == 3){
                load.loadText(); 
         
             }
             else if (rule == 4){
                Console.Write("What is the file name? ");
                load.DisplayJournal();
               
             }
             else{
                Console.WriteLine("Thanks for waiting! I am not smart and fast.");
                rule = 10;
                
             }
            

         }
    }
}
