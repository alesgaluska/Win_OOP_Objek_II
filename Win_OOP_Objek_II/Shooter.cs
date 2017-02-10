using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_OOP_Objek_II
{
    public class Shooter
    {
        string ShooterName;
        int Health = 100;

        public void WriteName(string NewName)
        {
            ShooterName = NewName;
        }

        public string GetName(Shooter Name)
        {
            return Name.ShooterName;
        }

        public int GetHealt(Shooter Name)
        {
            return Name.Health;
        }

        public void ShootUp(Shooter Name)
        {
            Name.Health -= 10;
        }

        public int HealUp(Shooter Name)
        {
            return Name.Health += 10;
        }

    }
}
