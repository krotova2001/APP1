using System;
using System.Collections.Generic;

namespace APP1;

public partial class EventCategory
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string EventType { get; set; } = null!;

    public virtual ICollection<EventCategoryToObjectType> EventCategoryToObjectTypes { get; set; } = new List<EventCategoryToObjectType>();

    public virtual ICollection<EventLog> EventLogs { get; set; } = new List<EventLog>();
}
