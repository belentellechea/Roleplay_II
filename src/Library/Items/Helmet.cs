using System.Data.Common;

namespace RoleplayGame
{
    public class Helmet : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
    }
}