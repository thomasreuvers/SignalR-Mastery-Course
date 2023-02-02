using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Scaffold.Web.Hubs;

public class ViewHub : Hub
{
    private static int ViewCount {get;set;}

    public async Task NotifyWatching(){
        ViewCount++;

        await Clients.All.SendAsync("viewCountUpdate", ViewCount);
    }
}