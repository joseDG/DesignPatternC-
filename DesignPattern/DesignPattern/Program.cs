using DesignPattern._1_SingletonPattern;
using DesignPattern._2_FactoryPattern;
using DesignPattern._3_DependencyInjectionPattern;

class Program
{
    static void Main(string[] args)
    {
        //Factory Pattern
        // SaleFactory StoreSaleFactory = new StoreSaleFactory(10);
        // SaleFactory InternetSaleFactory = new InternetSaleFactory(5);

        //ISale sale1 = StoreSaleFactory.GetSale();
        // sale1.Sell(200);

        //ISale sale2 = InternetSaleFactory.GetSale();
        // sale2.Sell(200);

        //Inyeccion de Dependencias
        var beer = new Beer("Corona", "Grupo Modelo", 1);
        var drink = new DrinkWithBeer(2, 2, beer);
        drink.Build();
    }
}