using System;
using System.Collections.Generic;
using System.Text;

namespace Bookingapi
{
    public class EventDTO
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime StartDate { get; set; }
            public List<string> SentInvitations { get; set; }
    }
}
