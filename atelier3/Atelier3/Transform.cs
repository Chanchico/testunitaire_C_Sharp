using System;
using System.Collections.Generic;

namespace Atelier3{
    public class Transform{
     
        public int Hour;
        public int Minute;
        string[] lettre = {
            "un",           //0
            "deux",         //1   
            "trois",        //2     
            "quatre",       //3    
            "cinq",         //4
            "six",          //5
            "sept",         //6    
            "huit",         //7   
            "neuf",         //8
            "dix",          //9
            "onze",         //10    
            "midi",         //11
            "minuit",       //12
            "onze",         //13
            "douze",        //14
            "treize",       //15
            "quatorze",     //16
            "moins quart",  //17
            "et quart",     //18
            "seize",        //19
            "vingt",        //20
            "trente",       //21
            "quarante",     //22
            "cinquante"     //23
        };

        public Transform(int hour, int minute){
            this.Hour = hour;
            this.Minute = minute;
            DateTime Hour = new DateTime(1, 1, 1, hour, minute, 0);
        }

        


    }
}