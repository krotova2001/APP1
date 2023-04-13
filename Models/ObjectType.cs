using System;
using System.Collections.Generic;

namespace APP1;

public partial class ObjectType
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<EventCategoryToObjectType> EventCategoryToObjectTypes { get; set; } = new List<EventCategoryToObjectType>();

    public virtual ICollection<EventLog> EventLogs { get; set; } = new List<EventLog>();
}
