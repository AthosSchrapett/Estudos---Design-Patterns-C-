
using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

static void Init(Server server)
{
    server.RegisterUser("master@hcode.com.br", "124568777");
    server.RegisterUser("user@hcode.com.br", "55566658898");

    Middleware middleware = new CheckUserMiddleware(server);

    middleware.LinkWith(new CheckPermissionMiddleware());

    server.SetMiddleware(middleware);
}

Server server = new();

Init(server);

bool done = false;

do
{
    Console.WriteLine("Digite o seu e-mail: ");
    string email = Console.ReadLine();

    Console.WriteLine("Digite a sua senha: ");
    string password = Console.ReadLine();

    done = server.Login(email, password);

} while (!done);

Console.ReadLine();