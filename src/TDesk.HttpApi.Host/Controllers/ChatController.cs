using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDesk.RabbitMQ;
using Volo.Abp.AspNetCore.Mvc;

namespace TDesk.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ChatController : AbpController
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpPost]
        public async Task<IActionResult> SendMessageAsync()
        {
            await _chatService.SendMessageAsync();
            return Ok();
        }
    }
}
