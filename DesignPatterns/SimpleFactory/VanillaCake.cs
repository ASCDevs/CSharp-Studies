using System;

namespace SimpleFactory{
    public class VanillaCake : Cake
    {

        public VanillaCake(){
            this.flavorName = "Vanilla Cake";
            this.cakeKg = 2;
            this.pricePerKg = 14.75;
        }
        public override void cookingSteps()
        {
            Console.WriteLine("Preparing ingredients for "+cakeKg+"Kg of "+flavorName+"...");
            Console.WriteLine("Mixing ingredients...");
            Console.WriteLine("Baking...");
            Console.WriteLine("Ready to pack!");
        }

        public override void packingProcedures()
        {
            Console.WriteLine("Separating the packaging for baked cake...");
            Console.WriteLine("Tagging for the customer...");
            Console.WriteLine("Ready for delivery!");
        }
    }
}