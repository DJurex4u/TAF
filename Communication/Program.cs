// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using System.Text;

Console.WriteLine("Hello, World!");

var client = new ClientWebSocket();
await client.ConnectAsync(new Uri("wss://ws.postman-echo.com/raw"), CancellationToken.None);
Console.WriteLine("Connected!");

ArraySegment<byte> byteToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes("poruka"));
await client.SendAsync(byteToSend, WebSocketMessageType.Text, true, new CancellationToken());

var receiveTask = Task.Run(async () =>
{
    var buffer = new byte[1024 * 4];
	while (true)
	{
		var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        var message = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
        Console.WriteLine(message);

        if (result.MessageType == WebSocketMessageType.Close)
		{
			break;
		}		
	}
});

await receiveTask;