using System;

namespace SimpleFactory{
    public class CakeShop{
        public void DayOrders(){
            Console.WriteLine("Choose cake flavor: ");
            Console.WriteLine("1 - Cheesecake ");
            Console.WriteLine("2 - Chocolate");
            Console.WriteLine("3 - Vanilla");
            string selected = Console.ReadLine();

            try{
                //Cake chosenCake = CakeSimpleFactory.CreateCake(selected);
                //chosenCake.cookingSteps();
                //chosenCake.packingProcedures();
                //chosenCake.calcCakePrice();

            }catch(Exception e){
                Console.WriteLine("Error: "+e.Message);
            }
        }
    }
}