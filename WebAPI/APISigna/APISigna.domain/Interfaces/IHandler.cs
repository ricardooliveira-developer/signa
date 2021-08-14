using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Interfaces
{
    public interface IHandler
    {
        IReadOnlyCollection<Notification> Notifications();
    }
}
