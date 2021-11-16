using System;

namespace SimpleFactory{
    public class CakeShop{
        public void DayOrders(){
            bool endOrders = false;
            
            do{
                Console.Clear();
                Console.WriteLine("Choose cake flavor: ");
                Console.WriteLine("1 - Cheesecake ");
                Console.WriteLine("2 - Chocolate");
                Console.WriteLine("3 - Vanilla");
                string selected = Console.ReadLine();

                try{
                    Cake chosenCake = CakeSimpleFactory.CreateCake(selected);
                    chosenCake.cookingSteps();
                    chosenCake.packingProcedures();
                    chosenCake.calcCakePrice();

                }catch(Exception e){
                    Console.WriteLine("Error: "+e.Message);
                }

                string answer = "";
                do{
                    Console.WriteLine("> Make another cake? (1)Yes (0)No");
                    answer = Console.ReadLine();
                }while(!(answer.Equals("1")||answer.Equals("0")));

               endOrders = answer.Equals("1");
                
            }while(endOrders);
            Console.WriteLine("Closed Store!");
        }
    }
}