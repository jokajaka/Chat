using Microsoft.AspNetCore.SignalR;
using Pulicoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulicoo.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMessage(Message message) =>
			await Clients.All.SendAsync("receiveMessage", message);
	}
}
