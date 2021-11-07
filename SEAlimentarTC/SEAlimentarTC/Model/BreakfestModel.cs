using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class BreakfestModel
    {
        private AppDbContext AppDataBase { get; set; }

        public BreakfestModel()
        {
            AppDataBase = new AppDbContext();
        }

        public async Task<bool> InsertBreakfestAsync(Breakfest Breakfest)
        {
            try
            {
                AppDataBase.Breakfest.Add(Breakfest);
                int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

                return lines > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
