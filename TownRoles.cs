using System;

namespace townie
{
    class villager : Role
    {
        public villager()
        {
            this.roleName = "Villager";
            this.roleEvil = "Innocent";
            assignImmunityFlags();
        }
    }
    
    class sheriff : Role
    {
        public sheriff()
        {
            this.roleName = "Sheriff";
            this.roleEvil = "Innocent";
            assignImmunityFlags();
        }
        public override string NightAction(Player[] targets)
        {
            return $"Your target is {targets[0].playerRole.roleEvil}";
        }
    }
    class vigilante : Role
    {
        bool hasKilledTownie = false;
        int bulletsLeft = 3;

        public vigilante()
        {
            this.roleName = "Vigilante";
            this.roleEvil = "Innocent";
            this.attack = 1;
            assignImmunityFlags();
        }
        public override string NightAction(Player[] targets)
        {
            if(hasKilledTownie == true)
            {
                //kill himself
                return "You could not live with the guilt";
            }
            else if ()
            
        }
    }
}