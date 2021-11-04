using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SEAlimentarTC.Dtos;

namespace SEAlimentarTC.ViewModel
{
    class GenerateEnvironmentDefault
    {
        /**
         * Inserção dos cardápios pré definidos
         * **/
        public async Task InsertAllFoodMenus1600KcalAsync()
        {
            /**
             * REFEIÇÕES DE 1600 Kcal
             * **/

            //Cardápio 1
            FoodMenu FoodMenu1 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1600 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sobremesa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS, FRESCAL (2 Fatias finas de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GERGELIM, SEMENTE (1 Colher de chá de 5,00 g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (3 Colheres de sopa cheias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (1 Concha de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FILÉ DE PEIXE GRELHADO (1 Filé de 130,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM  (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 e ¼ Colheres de mesa de 50,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 170,00ml)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (1 e ¼ Colheres de sopa cheias de 22,50g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, DOCE, COZIDA (1 Unidade pequena de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (4 Colheres de sopa médias de 25,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SELETA DE LEGUMES  (2 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA VERDE MISTA (3 Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de chá de 5,00ml)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÊRA, PARK, CRUA (1 Unidade média de 140,00g)" });


            //Cardápio 2
            FoodMenu FoodMenu2 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1600 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (½ Unidade comercial de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sobremesa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "POLENTA, PRÉ-COZIDA (1 Xícara de 90,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ESPINAFRE REFOGADO (2 Colheres de mesa de 55,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (3 Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (1 Concha de 100,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BERGAMOTA (2 Unidades médias de 100,00 g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSAS, MIX DE NOZES E OLEAGINOSAS (1 Xícara de cafézinho de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CHOCOLATE, 70% CACAU, CHOCOLIFE (½ Tablete de 30,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now,ItemName = "LEGUMES REFOGADOS MISTOS (5 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now,ItemName = "PEITO DE FRANGO GRELHADO (1 e ¼ Pedaços de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now,ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidades de 120,00g)" });


            //Cardápio 3
            FoodMenu FoodMenu3 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1600 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, CENTEIO (2 Fatias de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MELÃO, CRU (1 Fatia grande de 220,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Xícara de chá de 150,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAFÉ, SOLÚVEL (1 Colher de chá cheia de 6,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, CASTANHA-DO-BRASIL, CRUA (2 Unidades de 3,75g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANDIOCA, COZIDA (1 Unidade de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARRÉ DE PORCO ACEBOLADO (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (2 Colheres de mesa de 55,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (3 Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LENTILHA, COZIDA(1 Concha de 100,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (1 Unidade média de 50,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FERMENTO EM PÓ, QUÍMICO (1 Colher de cafezinho de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CACAU, PÓ (1 Colher de chá de 5,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, SOBRECOXA, SEM PELE, ASSADA (1 Pedaço de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABÓBORA, MORANGA, REFOGADA (1 e ½ Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PURÊ DE BATATA (3 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA MISTA VARIADA (3 Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (½ Colher de sopa de 10,00ml)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidades de 120,00g)" });

        }

        public async Task InsertAllFoodMenus1800KcalAsync()
        {
            /**
             * REFEIÇÕES DE 1800 Kcal
             * **/

            //Cardápio 1
            FoodMenu FoodMenu1 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1800 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS, FRESCAL (2 Fatias finas de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, SEM SAL (1 Colher de chá cheia de 7,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (2 Fatias finas de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Colher de chá de 5,00 g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAFÉ, INFUSÃO 10% (1 Colher de chá de 5,00 g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (4 Colheres de sopa cheias de 25,00 g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (1 Concha de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, PEITO, SEM PELE, GRELHADO (1 Pedaço médio de 120,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 Xícara de 70,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACAXI, CRU (1 Fatia média de 80,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO  (1 Unidade comercial de 170,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidade média de 130,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, DOCE, COZIDA (1 Unidade pequena de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 Xícara de 70,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });


            //Cardápio 2
            FoodMenu FoodMenu2 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1800 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (2 Unidades médias de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, ORÉGANO, MOÍDO (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (¼ Colher de sopa de 10,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 7, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, AÇAFRÃO (1 Pitada de 1,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANDIOCA, COZIDA (1 Unidade de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LENTILHA, COZIDA (1 Concha de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (½ Colher de sopa de 10,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES À JARDINEIRA (3 Colheres de mesa de 40,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Copo de 200,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MORANGO, CRU (10 Unidades médias de 12,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, PEITO, SEM PELE, COZIDO (1 Pedaço de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00 g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/CEBOLA (1 Porção de 80,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LARANJA, VALÊNCIA, CRUA (1 Unidade grande de 170,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "KIWI, CRU (2 Unidades de 40,00 g)" });


            //Cardápio 3
            FoodMenu FoodMenu3 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 1800 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,000g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MORANGO, CRU (10 Unidades médias de 12,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (2 Colheres de sopa cheias de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SEMENTE DE CHIA, INTEGRAL (1 Colher de sobremesa de 10,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSAS, MIX DE NOZES E OLEAGINOSAS (1 Xícara de cafézinho de 15,00g)" });
            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidade de 120,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MACARRÃO, COZIDO (1 Concha média de 150,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (4 Colheres de sopa médias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (1 Porção de 70,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CENOURA COM ERVILHAS (1 e ½ Colheres de mesa de 40,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (1 Unidade média de 50,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FERMENTO EM PÓ, QUÍMICO (1 Colher de cafezinho de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CACAU, PÓ (1 Colher de chá de 5,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES REFOGADOS MISTOS  (3 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FILÉ DE PEIXE GRELHADO (1 Filé de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA VERDE MISTA (1 e ½ Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00 ml)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANGA, PALMER, CRUA (2 Fatias médias de 60,00g)" });

        }

        public async Task InsertAllFoodMenus2000KcalAsync()
        {
            /**
             * REFEIÇÕES DE 2000 Kcal
             * **/

            //Cardápio 1
            FoodMenu FoodMenu1 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2000 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS, FRESCAL (2 Fatias finas de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Colher de chá de 5,00 g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FARINHA DE CHIA, INTEGRAL (2 Colheres de sopa de 7,50g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÊRA, PARK, CRUA (¾ Unidade grande de 180,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, DOCE, COZIDA (1 e ¼ Unidades pequenas de 150,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LENTILHA, COZIDA (1 e ¼ Conchas médias de 90,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 e ¼ Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "COUVE, MANTEIGA, REFOGADA (1 Colher de sopa cheia de 40,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (¾ Copo de 200,00ml)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MORANGO, CRU (8 e ¼ Unidades médias de 12,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia de 120,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (1 e ¼ Colheres de sopa cheias de 22,50g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, FILÉ DE PEITO, S/ OSSO, S/ PELE (1 e ½ Pedaços de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABÓBORA, MORANGA, REFOGADA (3 Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, INGLESA, COZIDAE (1 Unidade média de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA VERDE MISTA (1 Colher de mesa de 50,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANGA, PALMER, CRUA (1 Fatia média de 60,00g)" });


            //Cardápio 2
            FoodMenu FoodMenu2 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2000 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 7, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, ABÓBORA, SEMENTE (1 Colher de sopa de 15,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSAS, MIX DE NOZES E OLEAGINOSAS (1 Xícara de cafézinho de 15,00g)" });
            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BERGAMOTA (1 Unidade média de 100,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANDIOCA, COZIDA (1 Unidade de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PORCO, LOMBO, ASSADO (1 Unidade pequena de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/CEBOLA (1 e ¼ Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "REPOLHO, ROXO, REFOGADO (2 Colheres de mesa de 40,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACAXI, CRU (1 Fatia média de 80,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (6 Unidades de 30,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, AMENDOIM (2 Colheres de sopa de 10,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (2 Unidades médias de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00 g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE(1 e ¼ Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FARINHA DE CHIA, INTEGRAL (1 Colher de sobremesa de 12,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LARANJA, VALÊNCIA, CRUA (1 Unidade grande de 170,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "KIWI, CRU (2 Unidades de 40,00 g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MEL, DE ABELHA (¼ Colher de sopa de 20,00g)" });


            //Cardápio 3
            FoodMenu FoodMenu3 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2000 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MOZARELA (1 e ½ Fatias médias de 12,50g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, SEM SAL (1 Colher de sopa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 e ¼ Fatias de 120,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Copo de 200,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAFÉ, SOLÚVEL (1 Colher de sobremesa de 6,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LARANJA, VALÊNCIA, CRUA (1 Unidade de 120,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (4 Colheres de sopa cheias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (1 e ¾ Conchas médias de 60,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00 g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 e ¼ Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BERGAMOTA (1 e ½ Unidades médias de 100,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, INTEGRAL, ACTIVIA (1 Unidade comercial de 170,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MACARRÃO, COZIDO (3 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA(1 Filé de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (1 e ¼ Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABÓBORA, MORANGA, REFOGADA (3 Colheres de mesa de 50,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, CRUA (1 e ¼ Unidades de 120,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Copo de 200,00ml)" });

        }

        public async Task InsertAllFoodMenus2200KcalAsync()
        {
            /**
             * REFEIÇÕES DE 2200 Kcal
             * **/

            //Cardápio 1
            FoodMenu FoodMenu1 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2200 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS, FRESCAL (2 Fatias finas de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (¾ Copo de 200,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAFÉ, SOLÚVEL (1 Colher de chá cheia de 6,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 7, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, SEM SAL (¾ Colher de sopa de 10,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LARANJA, PÊRA, CRUA (1 Unidade média de 190,00g)" });
            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, CASTANHA-DO-BRASIL, CRUA (2 Unidades médias de 3,75g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (6 Colheres de sopa cheias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 Xícara de 70,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 170,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidade média de 130,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (2 Colheres de sopa cheias de 15,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, DOCE, COZIDA (1 Unidade média de 180,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 Xícara de 70,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (1 Colheres de sopa de 15,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANGA, PALMER, CRUA (1 Fatia média de 60,00g)" });


            //Cardápio 2
            FoodMenu FoodMenu2 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2200 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Copo de 200,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MORANGO, CRU (10 Unidades médias de 12,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (2 Unidades médias de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (½ Colher de sopa de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÊRA, PARK, CRUA (1 Unidade média de 140,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANDIOCA, COZIDA (1 e ½ Unidades de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, COXA/SOBRECOXA, S/OSSO, S/PELE (1 Pedaço médio de 120,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (1 Porção de 70,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CHOCOLATE, 70% CACAU, CHOCOLIFE (1 Tablete de 30,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (2 Colheres de sopa cheias de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA DE FRUTA (1 Pote de sobremesa de 150,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LENTILHA, COZIDA (1 Concha de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES REFOGADOS MISTOS (3 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, GREGO, TRADICIONAL (½ Unidade de 100,00)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "KIWI, CRU (2 Unidades de 40,00 g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sobremesa de 10,00g)" });


            //Cardápio 3
            FoodMenu FoodMenu3 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2200 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, ORÉGANO (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, AÇAFRÃO (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 7, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SEMENTE DE CHIA, INTEGRAL (1 Colher de sobremesa de 10,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BERGAMOTA (3 Unidades médias de 100,00g)" });
            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, CASTANHA-DO-BRASIL, CRUA (1 e ¾ Unidades de 3,75g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (5 Colheres de sopa cheias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PORCO, LOMBO, ASSADO (1 Unidade pequena de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (1 e ¼ Colheres de mesa de 70,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CHOCOLATE, 70% CACAU, CHOCOLIFE (1 Porção de 20,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CACAU, PÓ (1 Colher de chá de 5,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "TAPIOCA, MANDIOCA, GOMA (2 Colheres de sopa de 20,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (1 Unidade média de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ISCAS DE FRANGO COM LEGUMES (½ Concha média de 200,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (1 Porção de 70,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 7, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SUCO, UVA, CONCENTRADO, ENVASADO (¾ Copo usual de 200,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANGA, PALMER, CRUA (1 Fatia média de 60,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });

        }

        public async Task InsertAllFoodMenus2500KcalAsync()
        {
            /**
             * REFEIÇÕES DE 2500 Kcal
             * **/

            //Cardápio 1
            FoodMenu FoodMenu1 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2500 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MELÃO, CRU (1 Fatia grande de 220,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SEMENTE DE CHIA, INTEGRAL (1 e ½ Colheres de sopa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MEL, DE ABELHA (1 Colher de chá de 5,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (2 Unidades médias de 50,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ARROZ, TIPO 1, COZIDO (5 Colheres de sopa cheias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 e ½ Pedaços de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/BETERRABA/COUVE-FLOR (1 Xícara de 70,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACAXI, CRU (2 Fatias médias de 80,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, DE CENTEIO (2 Fatias finas de 25,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidade média de 130,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS, FRESCAL (2 Fatias médias de 25,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, SEM SAL (1 Colher de sopa de 10,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 5, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/CEBOLA (1 Porção de 80,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PEITO DE FRANGO GRELHADO  (1 Filé de 150,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PURÊ DE BATATA DOCE (4 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES REFOGADOS MISTOS (3 Colheres de mesa de 40,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABACATE, CRU (4 Colheres de sopa de 25,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (1 Colheres de sopa de 15,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu1.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LARANJA, VALÊNCIA, CRUA (1 Unidade grande de 170,00g)" });


            //Cardápio 2
            FoodMenu FoodMenu2 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2500 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "TAPIOCA, MANDIOCA, GOMA (3 Colheres de sopa de 20,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SEMENTE DE CHIA, INTEGRAL (1 e ½ Colheres de sopa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, CRU (2 Unidades médias de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, CREME DE RICOTA (1 Colher de sopa de 30,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAQUI, CRU (1 Unidade de 100,00g)" });
            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, CASTANHA-DO-BRASIL, CRUA (1 e ¾ Unidades de 3,75g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANDIOCA, COZIDA (1 Unidade de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LENTILHA, COZIDA (1 e ½ Conchas médias de 90,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (5 Colheres de sopa médias de 25,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA TOMATE/ALFACE/CEBOLA (1 Porção de 80,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "ABÓBORA, MORANGA, REFOGADA (3 Colheres de mesa de 50,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GRANOLA (2 Colheres de sopa cheias de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MORANGO, CRU (10 Unidades médias de 12,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FRANGO, COXA/SOBRECOXA, S/OSSO, S/PELE (1 e ½ Pedaços de 100,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA VERDE MISTA (3 Colheres de mesa de 50,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES REFOGADOS MISTOS (4 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA, DOCE, COZIDA (1 Unidade pequena de 150,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADOL (1 Copo de 200,00ml)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 4, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sobremesa de 15,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 5, FoodMenuID = FoodMenu2.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CACAU, PÓ (2 Colheres de chá de 5,00g)" });


            //Cardápio 3
            FoodMenu FoodMenu3 = await new FoodMenuModel().InsertFoodMenuAsync(new FoodMenu() { InsertDate = DateTime.Now, TotalKcal = 2500 });

            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEITE, SEMI-DESNATADO (1 Copo de 200,00ml)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CAFÉ, SOLÚVEL (1 Colher de chá cheia de 6,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PÃO, CENTEIO (2 Fatias de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "QUEIJO, MINAS/FRESCAL (2 Fatias médias de 25,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MANTEIGA, SEM SAL (1 Colher de sopa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 7, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MELÃO, CRU (1 Fatia grande de 220,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 8, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SEMENTE DE CHIA, INTEGRAL (1 e ½ Colheres de sopa de 10,00g)" });
            await new BreakfestModel().InsertBreakfestAsync(new Breakfest() { BreakfestID = 9, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MEL, DE ABELHA (1 Colher de chá de 5,00g)" });

            await new MorningSnackModel().InsertMorningSnackAsync(new MorningSnack() { MorningSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OLEAGINOSA, CASTANHA-DO-BRASIL, CRUA (1 Punhado de 20,00g)" });

            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MACARRÃO, COZIDO (1 Concha média de 150,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CARNE, BOVINA, MÉDIA GORDURA (1 Pedaço de 100,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA REPOLHO/CENOURA/TOMATE (3 Colheres de mesa de 50,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAMÃO, FORMOSA, CRU (1 Fatia média de 170,00g)" });
            await new LunchModel().InsertLunchAsync(new Lunch() { LunchID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FEIJÃO, PRETO, COZIDO (2 Conchas médias de 60,00g)" });

            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "OVO, DE GALINHA, INTEIRO, COZIDO/10 MINUTOS (1 Unidade média de 50,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AVEIA, FLOCOS FINOS (2 Colheres de sopa de 15,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BANANA, PRATA, CRUA (3 Unidades de 30,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "FERMENTO EM PÓ, QUÍMICO (1 Colher de cafezinho de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CONDIMENTO, CANELA MOÍDA (1 Pitada de 1,00g)" });
            await new AfternoonSnackModel().InsertAfternoonSnackAsync(new AfternoonSnack() { AfternoonSnackID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "CHOCOLATE, 70% CACAU, CHOCOLIFE (1 Porção de 20,00g)" });

            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "LEGUMES REFOGADOS MISTOS (4 Colheres de mesa de 40,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "PEIXE, ATUM, SÓLIDO, EM ÓLEO (5 Colheres de sopa de 20,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "BATATA SAUTÉE (2 Colheres de mesa de 60,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 4, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "GERGELIM, SEMENTE  (1 Colher de sopa de 15,00g)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 5, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "AZEITE, DE OLIVA, EXTRA VIRGEM (1 Colher de sopa de 10,00ml)" });
            await new DinnerModel().InsertDinnerAsync(new Dinner() { DinnerID = 6, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "SALADA VERDE MISTA (3 Colheres de mesa de 50,00g)" });

            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 1, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "IOGURTE, NATURAL, DESNATADO (1 Unidade comercial de 185,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 2, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MAÇÃ, FUJI, COM CASCA, CRUA (1 Unidade média de 130,00g)" });
            await new AfterDinnerModel().InsertAfterDinnertAsync(new AfterDinner() { AfterDinnerID = 3, FoodMenuID = FoodMenu3.FoodMenuID, InsertDate = DateTime.Now, ItemName = "MEL, DE ABELHA (1 Colher de chá de 5,00g)" });
        }
    }
}
