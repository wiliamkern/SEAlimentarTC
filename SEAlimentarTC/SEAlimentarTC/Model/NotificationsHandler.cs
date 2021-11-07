using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotification;
namespace SEAlimentarTC.Model
{
    class NotificationsHandler
    {

        public void GenerateFoodMenuNotification(DateTime day)
        {
            for (int moment = 1; moment <= 7; moment++)
                new NotificationsHandler().ScheduleNotification(day, moment);
        }

        public void ScheduleNotification(DateTime day, int moment)
        {
            TimeSpan ts = new TimeSpan();

            switch (moment)
            {
                case 1: // café da manhã
                    ts = new TimeSpan(06, 50, 0);
                    BuildNotification(day.Date + ts, "Café da manhã", "Lembre-se de realizar seu café da manhã às 07:00 horas", moment);
                    break;
                case 2: // lanche da manhã
                    ts = new TimeSpan(09, 50, 0);
                    BuildNotification(day.Date + ts, "Lanche da manhã", "Lembre-se de realizar seu lanche às 10:00 horas", moment);
                    break;
                case 3: // almoço
                    ts = new TimeSpan(11, 50, 0);
                    BuildNotification(day.Date + ts, "Almoço", "Lembre-se de realizar seu almoço às 12:00 horas", moment);
                    break;
                case 4: // lanche da tarde
                    ts = new TimeSpan(14, 50, 0);
                    BuildNotification(day.Date + ts, "Lanche", "Lembre-se de realizar seu lanche às 15:00 horas", moment);
                    break;
                case 5: // jantar
                    ts = new TimeSpan(19, 50, 0);
                    BuildNotification(day.Date + ts, "Jantar", "Lembre-se de realizar seu jantar às 20:00 horas", moment);
                    break;
                case 6: // ceia
                    ts = new TimeSpan(21, 50, 0);
                    BuildNotification(day.Date + ts, "Ceia", "Lembre-se de realizar sua ceia às 22:00 horas", moment);
                    break;
                case 7: // água
                    ts = new TimeSpan(11, 00, 0);
                    BuildNotification(day.Date + ts, "Importante beber água!", "Lembre-se de tomar água durante o dia. O recomendado é de 30 a 35 ml por kg de peso!", moment);

                    ts = new TimeSpan(16, 00, 0);
                    BuildNotification(day.Date + ts, "Importante beber água!", "Lembre-se de tomar água durante o dia. O recomendado é de 30 a 35 ml por kg de peso!", moment);

                    break;
            }
        }

        public void BuildNotification(DateTime day, string title, string message, int number)
        {
            if(day > DateTime.Now) // só cria as notificações para datas maiores que atual
            {
                var notification = new NotificationRequest
                {
                    BadgeNumber = number,
                    Description = message,
                    Title = title,
                    NotificationId = number,
                    Schedule =
                    {
                        NotifyTime = day
                    }
                };

                // seta para mostrar a notificação
                Task.Run(async () =>
                {
                    await NotificationCenter.Current.Show(notification);
                });
            }
        }
    }
}
