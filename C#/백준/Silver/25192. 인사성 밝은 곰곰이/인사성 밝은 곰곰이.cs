using System;
using System.Collections.Generic;
 
 public class Program
 {
     static void Main()
     {   
         Dictionary<string,int> enteredPerson = new Dictionary<string,int>();
         int inputNum = int.Parse(Console.ReadLine());
         int answer = 0;
         for(int i=0; i < inputNum;i++)
         {
             string str = Console.ReadLine();
             if(str == "ENTER")
             {
                enteredPerson.Clear();
                continue;
             }
             if(enteredPerson.ContainsKey(str))
             {
                enteredPerson[str] += 1;     
             }
             else
             {
                enteredPerson.Add(str,1);   
                answer += 1;
             }
             
         }
         
         Console.WriteLine(answer);
         
     }
     
     
 }