using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class LunchModel
    {
        private AppDbContext AppDataBase { get; set; }

        public LunchModel()
        {
            AppDataBase = new AppDbContext();
        }

        public async Task<bool> InsertLunchAsync(Lunch Lunch)
        {
            AppDataBase.Lunch.Add(Lunch);
            int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return lines > 0 ? true : false;
        }
    }
}
