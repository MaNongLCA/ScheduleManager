using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatures{
   public int health;
   public int speed;
    
    public Creatures()
    {
        health = 10;
        speed = 0;
    }

    public virtual void Death()
    {
        Debug.Log("Your dead");
    }

    public virtual void Attack()
    {
        Debug.Log("Attack!");
    }

    public virtual void Move()
    {
        Debug.Log("Run!");
    }
}
