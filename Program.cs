﻿using System;

namespace Multifabriken
{
    class Program
    {
        //Metod för att välja modell på bilen
        static string carModel()
        {
            Console.WriteLine("Vilken bilmodell vill du ha?");
            Console.WriteLine("1. Volvo");
            Console.WriteLine("2. Saab");
            Console.WriteLine("3. Ford");
            string modelChoise = Console.ReadLine(); //try catch
            return modelChoise;
        }

        //Metod för att välja färg på bilen 
        static string carColor()
        {
            Console.WriteLine("Vilken färg ska bilen ha? Mata in din färgkod i hex värde: ");
            string colorChoise = Console.ReadLine();
            return colorChoise;
        }
        
        //Metod för att välja lyx eller interiör
        static string carInterior()
        {
            Console.WriteLine("Välj din inredning:");
            Console.WriteLine("1. Lyx");
            Console.WriteLine("2. Standard");
            string interiorChoise = Console.ReadLine();
            
            return interiorChoise;
        }

        //Metod för att välja godistyp
        static string candyMenu(){
            Console.WriteLine("Vilken typ av godis vill du ha?");
            Console.WriteLine("1. Hallon");
            Console.WriteLine("2. Lakris");
            Console.WriteLine("3. Jordgubb");
            Console.WriteLine("4. Päron");
            string flavourChoise = Console.ReadLine();//try catch / switch?
            return flavourChoise;
        }

        //Metod för att hämta mängd på beställning från användaren. 
        static double getAmmount(){
            Console.WriteLine("Hur mycket?");
            double dAmmount = 0;
            string sAmmount = Console.ReadLine();
            try{
                dAmmount = Convert.ToDouble(sAmmount);
            }catch{
                Console.WriteLine("Ange mängden i siffror");
            }
            return dAmmount;
        }

        //Metod för mjölktyp
        static int milkType(){
            Console.WriteLine("Vilken fetthalt vill du ha? ");
            Console.WriteLine("(Mellan 2% och 11%)");
            string fat = Console.ReadLine();
            int partFat = 0;
            try{
                partFat = Convert.ToInt32(fat);
            }catch{
                Console.WriteLine("Ange fetthalt i heltal");
            }
            if (partFat < 2 || partFat > 11){
                Console.WriteLine("Fetthalten måste vara mellan 2% och 11%");
            }
            return partFat;
        }




        
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till multifabriken!");
            while (true)
            {
                //Meny, loopas
                Console.WriteLine("Vad vill du beställa?");
                Console.WriteLine("1. Godis");
                Console.WriteLine("2. Havremjölk");
                Console.WriteLine("3. Rör");
                Console.WriteLine("4. Bilar");
                Console.WriteLine("5. Skriv ut varor");
                Console.WriteLine("6. Avsluta programmet");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1"://Godis
                        candyMenu();
                        double candyWeight = getAmmount();
                        if (candyWeight < 1){
                            Console.WriteLine("Minst 1kg godis");
                        }else{
                            //lägg til i klass
                        }
                        break;
                    case "2"://Havremjölk
                        milkType();
                        double milkAmmount = getAmmount();
                        if (milkAmmount < 0.5){
                            Console.WriteLine("Du måste ange minst 0.5 liter mjölk");
                        }else{
                            //lägg till i klass
                        }
                        break;
                    case "3"://Rör

                        break;
                    case "4"://Bilar
                        carModel();
                        carColor();
                        carInterior();
                        break;
                    case "5"://Skriv ut beställning

                        break;//Avsluta programmet
                    case "6":

                        return;
                    default:
                        Console.WriteLine("Skriv ditt val endast med siffervärde");
                        break;
                }
            }
        }
    } 
}

