﻿using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class AfterDinnerModel
    {
        private AppDbContext AppDataBase { get; set; }

        public AfterDinnerModel()
        {
            AppDataBase = new AppDbContext();
        }

   /*     public async Task<Breakfest> GetBreakfestAsync(int Id)
        {
            return await AppDataBase.Breakfest.FindAsync(Id);
        }
   */
        public async Task<bool> InsertAfterDinnertAsync(AfterDinner AfterDinner)
        {
            AppDataBase.AfterDinner.Add(AfterDinner);
            int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return lines > 0 ? true : false;
        }

/*        public async Task<bool> UpdateFoodMenuAsync(FoodMenu foodMenu)
        {
            AppDataBase.FoodMenu.Update(foodMenu);
            int lines = await AppDataBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }

        public async Task<bool> DeleteFoodMenuAsync(int Id)
        {
            FoodMenu foodMenu = await GetFoodMenuAsync(Id);

            AppDataBase.FoodMenu.Remove(foodMenu);
            int lines = await AppDataBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }*/
    }
}
