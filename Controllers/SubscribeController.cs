using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactiveLikeApiDemo.Services;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ReactiveLikeApiDemo.Controllers
{
    [ApiController]
    [Route("api/subscribe")]

    public class SubscribeController : ControllerBase
    {
        [HttpGet]
        //Streams real-time post updates to the client using Server-Sent Events (SSE), subscribing to a broadcast service and sending serialized post updates with throttling support.
        public async Task Subscribe(CancellationToken token)
        {

            // Sets the response type to SSE so the browser can listen for real-time updates.

            // Used to keep the HTTP request alive until cancellation occurs.
            //TaskCompletionSource()

            // Subscribes to throttled post updates and sends each update to the client via SSE format.
            //subscription = BroadcastService.Subscribe(

            // Handles client disconnection by cleaning up the subscription and completing the task.
            // token.Register(() =>
            //{
            //Dispose the subscriber
            // Dispose the TaskCompletionSource()
            //}

            // Keeps the HTTP request open as long as the client is connected.
            //await tcs.Task;
        }
    }
}