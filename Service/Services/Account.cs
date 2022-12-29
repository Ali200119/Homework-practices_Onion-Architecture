using System;
using Service.Helpers.Enums;
using Service.Services.Interfaces;
using Service.Helpers.Constants;

namespace Service.Services
{
    public class Account : IAccount
    {
        private bool CheckRole(int roleId)
        {
            if (roleId == (int)Roles.SuperAdmin)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Login(string email, string password, int roleId)
        {
            if (email == AccountDatas.Email && password == AccountDatas.Password)
            {
                if (CheckRole(roleId))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return ResponseMessages.Success;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return ResponseMessages.Unauthorized;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            return ResponseMessages.Failed;
        }
    }
}

