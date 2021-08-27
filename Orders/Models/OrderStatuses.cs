using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    [Flags]
    public enum OrderStatuses
    {
        CREATED = 2,
        PROCESSING = 4,
        COMPLETED = 8,
        CANCELLED = 16,
        CLOSED = 32
    }
}
