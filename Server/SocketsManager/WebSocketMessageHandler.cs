using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.SocketsManager
{
	public class WebSocketMessageHandler:SocketHandler
	{
		public WebSocketMessageHandler(ConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
		{
		}

		public override async Task OnConnected(WebSocket socket)
		{
			await base.OnConnected(socket);

			var socketId = WebSocketConnectionManager.GetId(socket);
			await SendMessageToAllAsync($"{socketId} is now connected");

			Debug.WriteLine($"{socketId} has joined");
		}

		public override async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
		{
			var socketId = WebSocketConnectionManager.GetId(socket);
			var message = $"{socketId} said: {Encoding.UTF8.GetString(buffer, 0, result.Count)}";

			await SendMessageToAllAsync(message);
		}
	}
}
