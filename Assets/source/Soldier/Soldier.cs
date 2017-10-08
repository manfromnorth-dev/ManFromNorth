using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public int MovingPriority;
    public bool isAlive;
    public string Role;
    
    public SoldierEnums.Rank Rank;
    public SoldierEnums.Location Location;
    public SoldierEnums.Nationality Nationality;
    public SoldierEnums.MovingDirection MovableDirection;

    public virtual void Move(SoldierEnums.Location step)
    {
        Location += step;
        // Animation for movement
        //OnMove(step);//
    }

    public virtual void Die()
    {
        isAlive = false;
        // Animation for death
        //OnDie();
    }

    public virtual void Kill(Soldier soldier)
    {
        soldier.Die();
        // Animation for kill
        //OnKill(soldier);
    }

    public void Report()
    {
        // Report his/her own status
    }

    //protected abstract void OnMove(SoldierEnums.Location step);
    //protected abstract void OnDie();
    //protected abstract void OnKill(Soldier soldier);
}


