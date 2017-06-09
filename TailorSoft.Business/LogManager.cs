using System;
using TailorSoft.Business.Interfaces;
using TailorSoft.Database;

namespace TailorSoft.Business
{
    public class LogManager : ILogManager
    {
        public void LogMessage(string message, string messageExtension)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Logs.Add(new Database.Models.Log
                {
                    Id = Guid.NewGuid(),
                    CreatedDt = TimeHelper.GetCurrentDateTime(),
                    Message = message,
                    MessageExtension = messageExtension
                });

                db.SaveChanges();
            }
        }
    }
}
