using System.Collections.Generic;

namespace Data
{
    public class User
    {
        public long UserId { get; set; }
        public long ChannelId { get; set; }
        public List<Alert> Alerts { get; set; }
    }
}