using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo=="11111" && gamer.Name=="Sezer" && gamer.Surname=="Bozbıyık" && gamer.BirthYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
