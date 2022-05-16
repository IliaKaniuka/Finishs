using System;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float health = 1f;

   public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Dm();
        }

    }
    public void Dm()
    {
        Destroy(gameObject);
    }
}
