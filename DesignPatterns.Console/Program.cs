using DesignPatterns.Adapter.Implementations;
using DesignPatterns.Bridge;
using DesignPatterns.Bridge.Implementations;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.FactoryMethod.Models;
using DesignPatterns.Serialization.Extensions;
using DesignPatterns.Singleton.Implementations;
using Category = DesignPatterns.PrototypeClone.Models.Category;
using NYPizzaStore = DesignPatterns.FactoryMethod.Factories.NYPizzaStore;
using Product = DesignPatterns.PrototypeClone.Models.Product;

Console.WriteLine("Let's see design patterns\n");

//var sandwich = CreateSandwich();
//Console.WriteLine($"SANDWICH: {sandwich.Bread}, {sandwich.Cheese}, {sandwich.Condiments}, {sandwich.Protein}, {sandwich.Veggies}");

//CreatePizza(PizzaType.Pepperoni);
//CreateAbstractPizza();

//CreateProducts();
//CreateProductsSerialization();

//SingletonPattern();

//CreateProductsAdapter();

//BridgePattern();

CompositePattern();

#region Methods

Sandwich CreateSandwich()
{
    return new SandwichBuilder()
        .WithButterBread()
        .WithMeatProtein()
        .WithBBQCondiment()
        .Sandwich;
}

void CreatePizza(PizzaType type)
{
    new NYPizzaStore().OrderPizza(type);
}

void CreateAbstractPizza()
{
    DesignPatterns.AbstractFactory.Factories.PizzaStore nyStore = new DesignPatterns.AbstractFactory.Factories.NY.NYPizzaStore();
    DesignPatterns.AbstractFactory.Models.Pizzas.Pizza pizza = nyStore.OrderPizza(DesignPatterns.AbstractFactory.Models.Pizzas.PizzaType.Pepperoni);
    Console.WriteLine($"Pizza {pizza.Type} ready to be delivered to Rubén");

}

void CreateProducts()
{
    Product notebook = new("MacBook Pro", new Category("Computers"));
    Console.WriteLine(notebook);

    var iphone = notebook.DeepCopy();
    iphone.Name = "Iphone";
    iphone.Category!.Name = "Mobiles";
    Console.WriteLine(iphone);
}

void CreateProductsSerialization()
{

    DesignPatterns.Serialization.Models.Product notebook = new("MacBook Pro", new DesignPatterns.Serialization.Models.Category("Computers"));
    Console.WriteLine(notebook);

    var iphone = notebook.DeepCopy();
    iphone.Name = "Iphone";
    iphone.Category!.Name = "Mobiles";
    Console.WriteLine(iphone);
}

void SingletonPattern()
{
    var capitals = SingletonDataContainer.Instance;
    var capitals1 = SingletonDataContainer.Instance;
    var capitals2 = SingletonDataContainer.Instance;
    var capitals3 = SingletonDataContainer.Instance;

    Console.WriteLine($"London population is {capitals.GetPopulation("London")}");
}

void CreateProductsAdapter()
{
    var xmlConverter = new XmlConverter();
    var adapter = new XmlToJsonAdapter(xmlConverter);
    adapter.ConvertXmlToJson();
}

void BridgePattern()
{
    ReaderApp appWindows7 = new Windows7(new NormalDisplay()) { Text = "Learning bridge" };
    ReaderApp appWindows10 = new Windows10(new ReverseDisplay()) { Text = "Learning bridge" };

    appWindows7.Display();
    appWindows10.Display();
}

void CompositePattern()
{
    DesignPatterns.Composite.Product ram = new SimpleProduct("Ram 16GB", 20);
    DesignPatterns.Composite.Product processor = new SimpleProduct("Intel I7", 300);
    DesignPatterns.Composite.Product rom = new SimpleProduct("SSD 1TB", 200);

    DesignPatterns.Composite.Product pcGamer = new CompositeProduct("Basic Pc Gaming");
    pcGamer.Add(ram);
    pcGamer.Add(processor);
    pcGamer.Add(rom);

    Console.WriteLine(pcGamer.GetPrice());
}

#endregion