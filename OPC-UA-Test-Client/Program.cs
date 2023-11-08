using TitaniumAS.Opc.Client;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;

Console.WriteLine("Hello, World!");

Bootstrap.Initialize();
var url = UrlBuilder.Build("opc.tcp://127.0.0.1:4840/opcua/");

using (var server = new OpcDaServer(url))
{
    server.Connect();
}

Console.ReadLine();
