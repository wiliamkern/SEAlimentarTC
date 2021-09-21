using SEAlimentarTC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAlimentarTC.Repository
{
    public class UserModel
    {
        private UserContext AppDataBase { get; set; }

        public UserModel()
        {
            AppDataBase = new UserContext();
        }

        public async Task<User> GetUserAsync(int Id)
        {
            return await AppDataBase.User.FindAsync(Id);
        }

      /*  public async Task<List<User>> GetList(int ID = 0)
        {
            return AppDataBase.User.Where(w => w.Id == ID).ToList();
        }*/

        /**
         * Faz a inserção dos dados de usuário
         * **/
        public async Task<bool> InsertUseAsync(User user)
        {
            AppDataBase.User.Add(user);
            int lines = await AppDataBase.SaveChangesAsync(); // lines == linhas afetadas, se houver linhas afetadas retorna true, senão false

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
    }
}
