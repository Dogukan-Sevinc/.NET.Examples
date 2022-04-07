using MVC101.Models;
using System.Diagnostics;

namespace MVC101.Services.SmsService
{
    public class WissenSmsService : ISmsService
    {
        public object? EndPoint { get; internal set; }

        public SmsStates Send(SmsModel model)
        {
            Debug.Write(message: $"Wissen: {model.TelefonNo}-{model.Mesaj}");
            return SmsStates.Sent;
        }

       
    }
}
