using System;

namespace SimpleFactory{
    //Define-se como 'sealed' pois assim ninguém herda desta classe
    public sealed class CakeSimpleFactory{
        public static Cake CreateCake(string selected){
            Cake cake;
            if(selected.Equals("1")){
                cake = new CheeseCake();
            }else if(selected.Equals("2")){
                cake = new ChocolateCake();
            }else if(selected.Equals("3")){
                cake = new VanillaCake();
            }else{
                throw new ApplicationException("The selected flavor doesn't exists in our menu. :(");
            }

            return cake;
        }
    }
}