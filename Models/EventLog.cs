using System;
using System.Collections.Generic;

namespace APP1;

public partial class EventLog
{
    public Guid Id { get; set; }

    public Guid EventType { get; set; }

    public Guid EventCategory { get; set; }

    public Guid ObjectType { get; set; }

    public DateTime Date { get; set; }

    public string SubjectName { get; set; } = null!;

    public string SubjectUniqueInfo { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string EventDescription { get; set; } = null!;

    public Guid EventObjectId { get; set; }

    public string EventObjectName { get; set; } = null!;

    public virtual EventCategory EventCategoryNavigation { get; set; } = null!;

    public virtual EventType EventTypeNavigation { get; set; } = null!;

    public virtual ObjectType ObjectTypeNavigation { get; set; } = null!;
}
