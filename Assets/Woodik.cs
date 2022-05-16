
using UnityEngine;

public class Woodik : MonoBehaviour
{
   
    public float tree_health = 6f;
    // Start is called before the first frame update
public void TakeDamage(float amount)
    {
        tree_health -= amount;
        if(tree_health <= 0)
        {
            Die();
        }
      
    } public void  Die()
    {
        Destroy(gameObject);
    }

}
