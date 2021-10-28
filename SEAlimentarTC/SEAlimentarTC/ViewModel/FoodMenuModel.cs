﻿using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    class FoodMenuModel
    {
        private AppDbContext FoodMenuBase { get; set; }

        public FoodMenuModel()
        {
            FoodMenuBase = new AppDbContext();
        }

        public async Task<FoodMenu> GetFoodMenuAsync(int Id)
        {
            return await FoodMenuBase.FoodMenu.FindAsync(Id);
        }

        public async Task<FoodMenu> InsertFoodMenuAsync(FoodMenu foodMenu)
        {
            FoodMenuBase.FoodMenu.Add(foodMenu);
            int lines = await FoodMenuBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return foodMenu;
        }

        public async Task<bool> UpdateFoodMenuAsync(FoodMenu foodMenu)
        {
            FoodMenuBase.FoodMenu.Update(foodMenu);
            int lines = await FoodMenuBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }

        public async Task<bool> DeleteFoodMenuAsync(int Id)
        {
            FoodMenu foodMenu = await GetFoodMenuAsync(Id);

            FoodMenuBase.FoodMenu.Remove(foodMenu);
            int lines = await FoodMenuBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }
    }
}
