using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class MorningSnackModel
    {
        private AppDbContext AppDataBase { get; set; }

        public MorningSnackModel()
        {
            AppDataBase = new AppDbContext();
        }
        public async Task<bool> InsertMorningSnackAsync(MorningSnack MorningSnack)
        {
            AppDataBase.MorningSnack.Add(MorningSnack);
            int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return lines > 0 ? true : false;
        }
    }
}
