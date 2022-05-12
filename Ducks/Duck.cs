  

namespace Ducks
{
    public  abstract class Duck
    {
        public virtual Duck Quack() { Console.WriteLine("quack"); return this; }
        public virtual Duck Fly() { Console.WriteLine("fly"); return this; }
        public virtual Duck Figth() { Console.WriteLine("sdeng!"); return this; }
        public virtual Duck Eat() { Console.WriteLine("gnam"); return this; }

    }

    public class CountryDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("keck"); return this; }
        public override Duck Fly() { Console.WriteLine("fly"); return this; }
        public override Duck Figth() { Console.WriteLine("sdeng!"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam gnam gnam"); return this; }

    }

    public class CityDuck : Duck
    {
        public override Duck Fly() { Console.WriteLine("jump"); return this; }
        public override Duck Figth() { Console.WriteLine("I won't fly"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam"); return this; }
    }



    public class MountainDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("keck"); return this; }
        public override Duck Fly() { Console.WriteLine("high fly"); return this; }
        public override Duck Figth() { Console.WriteLine("I won't figth"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam gnam gnam"); return this; }

    }

    public class RubberDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("fake quaack"); return this; }
        public override Duck Fly() { Console.WriteLine("I don't fly"); return this; }
        public override Duck Figth() { Console.WriteLine("I won't figth"); return this; }
        public override Duck Eat() { Console.WriteLine("I don't eat"); return this; }

    }

    public class CrazyDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("quaakskdkakkkkakadquakka"); return this; }
        public override Duck Fly() { Console.WriteLine("high fly"); return this; }
        public override Duck Figth() { Console.WriteLine("Seek and destroy"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam"); return this; }

    }

    public class BorgDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("You will be assimilated.quack Resistance is futile.quack"); return this; }
        public override Duck Fly() { Console.WriteLine("jet fly"); return this; }
        public override Duck Figth() { Console.WriteLine("Seek and destroy"); return this; }
        public override Duck Eat() { Console.WriteLine("I don't eat"); return this; }

    }

    public class CloudDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("quaakskdkakkkkakadquakka"); return this; }
        public override Duck Fly() { Console.WriteLine("jet fly"); return this; }
        public override Duck Figth() { Console.WriteLine("I won't figth"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam gnam gnam"); return this; }

    }

    public class LazyDuck : Duck
    {
        public override Duck Quack() { Console.WriteLine("quack"); return this; }
        public override Duck Fly() { Console.WriteLine("fly"); return this; }
        public override Duck Figth() { Console.WriteLine("I won't figth"); return this; }
        public override Duck Eat() { Console.WriteLine("gnam"); return this; }
    }


}




