using System;

namespace SimpleFactory{
    public class CheeseCake : Cake
    {
        public CheeseCake(){
            this.flavorName = "Cheese Cake";
            this.cakeKg = 2;
            this.pricePerKg = 14.15;
        }
        public override void cookingSteps()
        {
            Console.WriteLine("Preparing ingredients for "+cakeKg+"Kg of "+flavorName+"...");
            Console.WriteLine("Mixing ingredients...");
            Console.WriteLine("Freezing...");
            Console.WriteLine("Ready to pack!");
        }

        public override void packingProcedures()
        {
            Console.WriteLine("Separating the packaging for cold cake...");
            Console.WriteLine("Tagging for the customer...");
            Console.WriteLine("Ready for delivery!");
        }
    }
}