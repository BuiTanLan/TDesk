using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TDesk.Conversations;
using Volo.Abp.EventBus.Distributed;

namespace TDesk.RabbitMQ
{

    public class ChatService : IChatService
    {
       
        private readonly IDistributedEventBus _distributedEventBus;
        public ChatService(IDistributedEventBus distributedEventBus)
        {
            _distributedEventBus = distributedEventBus;
        }
        public async Task SendMessageAsync()
        {
            //Guid targetId = new Guid(input.TargetUserName);

            await _distributedEventBus.PublishAsync(new Conversation("lan", "tu deptrai"));
        }


    }
}
