using System;
using System.Collections.Generic;

namespace APP1;

public partial class EventCategoryToObjectType
{
    public Guid Id { get; set; }

    public Guid ObjectType { get; set; }

    public Guid EventCategory { get; set; }

    public virtual EventCategory EventCategoryNavigation { get; set; } = null!;

    public virtual ObjectType ObjectTypeNavigation { get; set; } = null!;
}
