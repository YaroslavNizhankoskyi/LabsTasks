using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.Examples
{
    //ValueType - int, bool (значимые типы)
    //Object - string, User, WOrkInCompany, Student (ссылочные типы)
    internal static class ObjectRefernces
    {   
        public static void Solution()
        {
            var user = new User { Id = 10, Name = "Vasya" };
            var account = new Account { UserId = user.Id, AccountId = 1234, User = user };

            user.Id = 1234567;
            Console.WriteLine(account.UserId);
            Console.WriteLine(account.User.Id);

            var t = 't';
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Account
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public int AccountId { get; set; }

        public void SumUpId(ref int number)
        {
            number += number;
        }
    }
}
