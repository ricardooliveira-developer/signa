using APISigna.domain.Interfaces;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Handles
{
    public class BaseHandler : Notifiable, IHandler
    {
        IReadOnlyCollection<Notification> IHandler.Notifications()
        {
            return Notifications;
        }
    }
}
