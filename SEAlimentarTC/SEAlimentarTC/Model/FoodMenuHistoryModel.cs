using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.Model;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    public class FoodMenuHistoryModel
    {
        private AppDbContext AppDataBase { get; set; }

        public FoodMenuHistoryModel()
        {
            AppDataBase = new AppDbContext();
        }

        public bool InsertFoodMenuHistory(FoodMenuHistory foodMenuHistory)
        {
            int? nextID = AppDataBase.FoodMenuHistory.Max(u => (int?)u.FoodMenuHistoryID);
            foodMenuHistory.FoodMenuHistoryID = nextID.HasValue ? nextID.Value + 1 : 1;

            AppDataBase.FoodMenuHistory.Add(foodMenuHistory);
            int lines = AppDataBase.SaveChanges(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            if (LoggedModel.LoggedUser.ReceiveAlerts == true) // se o receber alertas estiver ativo, dispara para criar os alertas
                new NotificationsHandler().GenerateFoodMenuNotification(foodMenuHistory.MenuDay.Value);

            return lines > 0 ? true : false;
        }

        public List<FoodMenuHistory> GetList()
        {
            List<FoodMenuHistory> list = AppDataBase.FoodMenuHistory
                .Include(foodMenuHistory => foodMenuHistory.FoodMenuData)
                .OrderBy(o => o.MenuDay)
                .ToList();

            return list;
        }

        public FoodMenuHistory GetDataByDate(DateTime day)
        {
            FoodMenuHistory data = AppDataBase.FoodMenuHistory
                .Include(foodMenuHistory => foodMenuHistory.FoodMenuData)
                .Where(w => w.MenuDay.Value.Date == day.Date)
                .SingleOrDefault();

            return data;
        }
    }
}
