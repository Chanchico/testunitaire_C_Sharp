using System;
using System.Collections.Generic;

namespace Atelier3{
    public class Transform{
       public int hour;
       public int minute;

        public static Dictionary<int, string> dico = new Dictionary<int, string>();
        public static void Dico(){        
                dico.Add(0, "minuit");
                dico.Add(1, "une");
                dico.Add(2, "deux");
                dico.Add(3, "trois");
                dico.Add(4, "quatre");
                dico.Add(5, "cinq");
                dico.Add(6, "six");
                dico.Add(7, "sept");
                dico.Add(8, "huit");
                dico.Add(9, "neuf");
                dico.Add(10, "dix");
                dico.Add(11, "onze");
                dico.Add(12, "midi");          
                dico.Add(15, "quart");
                dico.Add(20, "vingt");
                dico.Add(25, "vingt-cinq");
                dico.Add(30 ,"trente");
             }
        
        public Transform(int hour, int minute){
            this.hour = hour;
            this.minute = minute;
        }
        public static string Convert(int hour, int minute){
            string heure = " heure ";
            string liant = "";
            string moment = " du matin";
            int diff = minute % 5;

            if (hour > 12){
                hour = hour - 12;
                moment = " de l'après-midi";
            }
            if( hour == 12 || hour == 0){
                heure = "";
            }
            if(minute % 5 != 0){
                minute -= diff;
            }
            if( minute >= 35){
                hour ++;
                minute = 60 - minute;
                liant ="moins ";
            }

            return "Il est " + dico[hour] + heure + liant + dico[minute] + moment;
        }
    }    
}