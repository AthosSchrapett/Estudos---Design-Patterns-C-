using Abstract_Factory.App;
using Abstract_Factory.Factories;

static Application ConfigureApplication()
{
    Application app;

    ITransportFactory transportFactory;
    string company = "99";

    if (company == "Uber")
        transportFactory = new UberTransport();
    else
        transportFactory = new NineNineTransport();

    app = new Application(transportFactory);

    return app;
}

Application app = ConfigureApplication();

app.StartRout();

Console.ReadLine();
