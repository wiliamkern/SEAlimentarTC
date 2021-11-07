using NRules.Fluent.Dsl;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEAlimentarTC.ViewModel
{
    public class RuleEngine : Rule
    {
        public override void Define() // definição de todas as regras
        {
            User user = new UserModel().GetUser(LoggedModel.LoggedUser.UserID);

            if (user.Sex == "F" && user.Age >= (decimal)18 && user.Age <= (decimal)30 && user.Imc.Value >= (decimal)18.5 && user.Imc <= (decimal)24.9)
            {
                // REGRA 1 (condição normal feminina entre 18 e 30 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "F" && u.Age >= (decimal)18 && u.Age <= (decimal)30 && u.Imc.Value >= (decimal)18.5 && u.Imc <= (decimal)24.9);
                Then() // sempre que a regra for verdadeira dispara o geração dos cardápios
                    .Do(_ => GenerateFoodMenus(2000));
            }

            if (user.Sex == "F" && user.Age >= (decimal)18 && user.Age <= (decimal)30 && user.Imc.Value >= (decimal)25 && user.Imc <= (decimal)29.9)
            {
                //REGRA 2 (condição de sobrepeso feminina entre 18 e 30 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "F" && u.Age >= (decimal)18 && u.Age <= (decimal)30 && u.Imc.Value >= (decimal)25 && u.Imc <= (decimal)29.9);
                Then()
                    .Do(_ => GenerateFoodMenus(1600));
            }

            if (user.Sex == "F" && user.Age > (decimal)30 && user.Age <= (decimal)60 && user.Imc.Value >= (decimal)18.5 && user.Imc <= (decimal)24.9)
            {
                //REGRA 3 (condição normal feminina entre 31 e 60 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "F" && u.Age > (decimal)30 && u.Age <= (decimal)60 && u.Imc.Value >= (decimal)18.5 && u.Imc <= (decimal)24.9);
                Then()
                    .Do(_ => GenerateFoodMenus(2000));
            }

            if (user.Sex == "F" && user.Age > (decimal)30 && user.Age <= (decimal)60 && user.Imc.Value >= (decimal)25 && user.Imc <= (decimal)29.9)
            {
                //REGRA 4 (condição de sobrepeso feminina entre 31 e 60 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "F" && u.Age > (decimal)30 && u.Age <= (decimal)60 && u.Imc.Value >= (decimal)25 && u.Imc <= (decimal)29.9);
                Then()
                    .Do(_ => GenerateFoodMenus(1800));
            }

            if (user.Sex == "M" && user.Age >= (decimal)18 && user.Age <= (decimal)30 && user.Imc.Value >= (decimal)18.5 && user.Imc <= (decimal)24.9)
            {
                //REGRA 5 (condição normal masculina entre 18 e 30 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "M" && u.Age >= (decimal)18 && u.Age <= (decimal)30 && u.Imc.Value >= (decimal)18.5 && u.Imc <= (decimal)24.9);
                Then()
                    .Do(_ => GenerateFoodMenus(2500));
            }

            if(user.Sex == "M" && user.Age >= (decimal)18 && user.Age <= (decimal)30 && user.Imc.Value >= (decimal)25 && user.Imc <= (decimal)29.9)
            {
                //REGRA 6(condição de sobrepeso masculina entre 18 e 30 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "M" && u.Age >= (decimal)18 && u.Age <= (decimal)30 && u.Imc.Value >= (decimal)25 && u.Imc <= (decimal)29.9);
                Then()
                    .Do(_ => GenerateFoodMenus(2000));
            }

            if (user.Sex == "M" && user.Age > (decimal)30 && user.Age <= (decimal)60 && user.Imc.Value >= (decimal)18.5 && user.Imc <= (decimal)24.9)
            {
                //REGRA 7 (condição normal masculina entre 31 e 60 anos)
                When()
                    .Match<User>(() => user, u => u.Sex == "M" && u.Age > (decimal)30 && u.Age <= (decimal)60 && u.Imc.Value >= (decimal)18.5 && u.Imc <= (decimal)24.9);
                Then()
                    .Do(_ => GenerateFoodMenus(2500));
            }

            if (user.Sex == "M" && user.Age > (decimal)30 && user.Age <= (decimal)60 && user.Imc.Value >= (decimal)25 && user.Imc <= (decimal)29.9)
            {
                //REGRA 8(condição de sobrepeso masculina entre 31 e 60 anos)
                When()
                 .Match<User>(() => user, u => u.Sex == "M" && u.Age > (decimal)30 && u.Age <= (decimal)60 && u.Imc.Value >= (decimal)25 && u.Imc <= (decimal)29.9);
                Then()
                    .Do(_ => GenerateFoodMenus(2200));
            }
        }

        // gera os cardápios conforme perfil do usuário
        public void GenerateFoodMenus(decimal totalKcal)
        {
            List<FoodMenu> lstFoodMenu = new FoodMenuModel().GetList().Where(w => w.TotalKcal == totalKcal).ToList();

            DateTime today = DateTime.Now;

            List<FoodMenuHistory> lstFoodMenuHistory = new FoodMenuHistoryModel().GetList();
            if (lstFoodMenuHistory.Count > 0)
            {
                if (lstFoodMenuHistory.Last().MenuDay.Value.Date >= today.Date) // caso já existam cardápios e data do último for maior do que a de hoje, gera + 1 dia em diante
                    today = lstFoodMenuHistory.Last().MenuDay.Value.AddDays(1);
            }

            foreach (FoodMenu item in lstFoodMenu)
            {
                new FoodMenuHistoryModel().InsertFoodMenuHistory(new FoodMenuHistory()
                {
                    MenuDay = today,
                    FoodMenuID = item.FoodMenuID,
                    InsertDate = DateTime.Now,
                    TotalKcal = item.TotalKcal
                });

                today = today.AddDays(1); // gera os cardápios por dia
            }
        }
    }
}
