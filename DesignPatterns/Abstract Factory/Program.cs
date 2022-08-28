using Abstract_Factory.App;
using Abstract_Factory.Factories;

static Application ConfigureApplication()
{
    Application app;

    ITransportFactory transportFactory;
    string company = "Lime";

    if (company == "Uber")
        transportFactory = new UberTransport();
    else if (company == "Lime")
        transportFactory= new LimeTransport();
    else
        transportFactory = new NineNineTransport();

    app = new Application(transportFactory);

    return app;
}

Application app = ConfigureApplication();

app.StartRout();

Console.ReadLine();
