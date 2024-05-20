// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using System.Text;

Console.WriteLine("Hello, World!");

var client = new ClientWebSocket();
await client.ConnectAsync(new Uri("wss://ws.postman-echo.com/raw"), CancellationToken.None);
Console.WriteLine("Connected!");

//todo: try catch

//todo: while client state open
while (client.State == WebSocketState.Open)
{
    Console.WriteLine("Type message:");
    string? message = Console.ReadLine();

    if (!String.IsNullOrEmpty(message))
    {
        ArraySegment<byte> byteToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
        await client.SendAsync(byteToSend, WebSocketMessageType.Text, true, new CancellationToken());
    }    

    var receiveTask = Task.Run(async () =>
    {
        var buffer = new byte[1024 * 4];

        while (true)
        {
            var response = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            var responseMessage = Encoding.UTF8.GetString(buffer, 0, response.Count);
            Console.WriteLine(responseMessage);

            if (response.EndOfMessage || response.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
        }
    });

    await receiveTask;
}
