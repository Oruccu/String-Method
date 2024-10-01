using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string name = "Hacker";
        string surname = "Rank";
        
        int DistanceName = name.Length; 
        int DistanceSurname = surname.Length;
        
        for(int i=0; i<name.Length; i++){
            //int number= name.Length-1; 
            if(i%2 == 0 || i == 0){
            Console.Write(name.Substring(i,1));
            }
        }  
        Console.Write(" "); 
        for(int i=0; i<name.Length; i++){
            //int number= name.Length-1; 
            if(i%2 == 1){
            Console.Write(name.Substring(i,1));
            }
            
        } 
        
        Console.WriteLine(" ");
        
        for(int i=0; i<surname.Length; i++){
            //int number= name.Length-1; 
            if(i%2 == 0 || i == 0){
            Console.Write(surname.Substring(i,1));
            }
        
    }
        Console.Write(" "); 
        for(int j=0 ; j<surname.Length; j++){
            //int number= name.Length-1; 
            if(j%2 == 1){
            Console.Write(surname.Substring(j,1));
            }
            
        } 
        
    }}
