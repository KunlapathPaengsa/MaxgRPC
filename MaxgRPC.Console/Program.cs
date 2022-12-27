using Grpc.Net.Client;
using MaxgRPC;

var inputName = new HelloRequest { Name= "max" };

var channel = GrpcChannel.ForAddress("https://localhost:7107/");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(inputName);

Console.WriteLine(reply.Message);
Console.ReadLine();
