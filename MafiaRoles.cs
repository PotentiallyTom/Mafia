using System;

namespace mafia
{
    class mafioso : Role
    {
        public mafioso()
        {
            this.roleName = "Mafioso";
            this.roleEvil = "Guilty";
            this.attack = 1;
            assignImmunityFlags();
        }
        public override string NightAction(Player[] targets)
        {
            if (targets[0].playerRole.defense < this.attack)
            {
                targets[0].die();
                return "";
            }
            else
            {
                return "Your target was too strong";
            }
        }
        
    }
}