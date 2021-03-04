using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TDesk.Conversations
{
    public class Conversation: AuditedAggregateRoot<Guid>
    {
        public Conversation(string pattern,  string messages)
        {
            Pattern = pattern;
            Messages = messages;

        }
        public string Pattern { get; set; } = "message";
        public string Messages { get; set; }
    }
}
