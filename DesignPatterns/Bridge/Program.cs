using Bridge.Platforms;
using Bridge.Transmissions;

static void StartLive(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    Live live = new Live(platform);

    live.Broadcasting();
    live.Result();
}

static void StartLiveAdvanced(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    AdvancedLive live = new AdvancedLive(platform);

    live.Broadcasting();
    live.Subtitle();
    live.Comments();
    live.Result();
}

Console.WriteLine("------------------------------------------");
StartLiveAdvanced(new Youtube());
Console.WriteLine("------------------------------------------");
StartLiveAdvanced(new Facebook());
Console.WriteLine("------------------------------------------");
StartLiveAdvanced(new TwitchTV());
Console.WriteLine("------------------------------------------");
Console.ReadLine();