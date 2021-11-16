using System;

namespace SimpleFactory{
    public abstract class Cake{
        public string flavorName { get; set; }

        public int cakeKg { get; set; }
        public double pricePerKg { get; set; }

        public void calcCakePrice(){
            Console.WriteLine("> Total: R$"+cakeKg * pricePerKg);
        }

        public abstract void packingProcedures();

        public abstract void cookingSteps();
    }
}