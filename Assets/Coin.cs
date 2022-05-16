using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float health = 1f;
    // Start is called before the first frame update
    public void TakeCare(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        Destroy(gameObject);
    }
    
}
