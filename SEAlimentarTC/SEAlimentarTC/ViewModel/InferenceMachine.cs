using NRules;
using NRules.Fluent;
using SEAlimentarTC.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAlimentarTC.ViewModel
{
    public class InferenceMachine
    {
        public void Infer() // realiza as inferência em cima dos dados 
        {
            //Load rules
            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(RuleEngine).Assembly));

            //Compile rules
            var factory = repository.Compile();

            //Create a working session
            var session = factory.CreateSession();

            //Load domain model
            var user = new UserModel().GetUser(LoggedModel.LoggedUser.UserID);
            var foodMenus = new FoodMenuModel().GetList();

            //Insert facts into rules engine's memory
            session.Insert(user);
            session.Insert(foodMenus);

            //Start match/resolve/act cycle
            session.Fire();
        }
    }
}
