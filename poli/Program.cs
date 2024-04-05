
namespace poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Shark akula = new Shark("Akula");
            //    Eagle qartal = new Eagle("Shahin");
            //    Cat mestan = new("Şahin");
            //    Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };

            //    foreach (var animal in animals)
            //    {
            //        Console.WriteLine(animal);
            //    }

            //List<Iswim> swimmes = new List<Iswim>();
            //   Iswim dog = new Dog("Garib");
            //   swimmes.Add(dog);

            //Iswim dog = new Dog("toplan");
            //Iswim fish = new Shark("Topi");
            //Iswim[] swwimes = new Iswim[] {fish, dog};
            //foreach (Iswim sw in swwimes)
            //{
            //    sw.Swim();
            //}

            Calculate c = new Calculate();
            Console.WriteLine(c.Add(1,5));
        }
    }
}
