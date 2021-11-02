using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class FoodMenuHistoryModel
    {
        private AppDbContext AppDataBase { get; set; }

        public FoodMenuHistoryModel()
        {
            AppDataBase = new AppDbContext();
        }

        public async Task<bool> InsertFoodMenuHistoryAsync(FoodMenuHistory foodMenuHistory)
        {
            AppDataBase.FoodMenuHistory.Add(foodMenuHistory);
            int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return lines > 0 ? true : false;
        }
    }
}
