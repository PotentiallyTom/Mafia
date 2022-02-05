using System;
using System.Collections.Generic;

abstract class Role
{
    public string roleName;
    public string roleEvil;
    public int defense = 0;
    public int attack = 0;
    public int priority = 0;
    public immunityFlags flags;
    public virtual void assignImmunityFlags()
    {
        this.flags.roleBlock = false;
        this.flags.detection = false;
        this.flags.visit = false;
    }
    public virtual string DayAction(Player[] targets)
    {
        return "Night has begun";
    }
    public virtual string NightAction(Player[] targets)
    {
        return "It is now Morning";
    }
    //called by the visitor, with the visitor putting themself as the argument
    public virtual string visitAction(Player visitor)
    {
        return null;
    }
}
class Player
{
    public Role playerRole;
    public bool isAlive;
    public Player()
    {
        this.isAlive = true;
    }
    public string die()
    {
        isAlive = false;
        return "You have died";
    }
}

struct immunityFlags
{
    public bool roleBlock;
    public bool detection;
    public bool visit;
}

