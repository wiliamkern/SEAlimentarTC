using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.ViewModel
{
    public class UserModel
    {
        private AppDbContext AppDataBase { get; set; }

        public UserModel()
        {
            AppDataBase = new AppDbContext();
        }

        public async Task<User> GetUserAsync(int Id)
        {
            /*AppDataBase.User.RemoveRange(AppDataBase.User);
            AppDataBase.SaveChanges();*/
            return await AppDataBase.User.FindAsync(Id);
        }

        /**
         * Faz a inserção dos dados de usuário
         * **/
        public bool InsertUseAsync(User user)
        {
            AppDataBase.User.Add(user);
            int lines = AppDataBase.SaveChanges(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

            return lines > 0 ? true : false;
        }

        /**
         * Faz a atualização dos dados de usuário
         * **/
        public async Task<bool> UpdateUserAsync(User user)
        {
            AppDataBase.User.Update(user);
            int lines = await AppDataBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }

        /**
         * Faz o delete dos dados de usuário
         * **/
        public async Task<bool> DeleteUserAsync(int Id)
        {
            User user = await GetUserAsync(Id);

            AppDataBase.User.Remove(user);
            int lines = await AppDataBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }

        /**
         * Faz o delete de todos usuários
         * **/
        public async Task<bool> DeleteAllUsersAsync()
        {
            var itemsToDelete = AppDataBase.Set<User>();
            AppDataBase.User.RemoveRange(itemsToDelete);

            int lines = await AppDataBase.SaveChangesAsync();

            return lines > 0 ? true : false;
        }
    }
}
