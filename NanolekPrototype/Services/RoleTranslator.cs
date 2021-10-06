using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanolekPrototype.Services
{
    public static class RoleTranslator
    {
        public static string GetRuRoleName(string roleName)
        {
            switch (roleName)
            {
                case "admin": return "Администратор";
                case "executor": return "Исполнитель";
                case "controller": return "Контролер";
            }

            return "";
        }
    }
}
