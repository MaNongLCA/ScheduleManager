using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Creatures {

    public Enemies()
    {
        health = 5;
        speed = 3;
    }

    public override void Death()
    {
        base.Death();

    }

    public override void Attack()
    {
        base.Attack();
    }

    public override void Move()
    {
        base.Move();
     
    }

}
