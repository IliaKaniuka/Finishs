using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigg : MonoBehaviour
{
    public Text tyt;
    public int coincnt;

    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tyt.text = coincnt.ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            tyt.text = coincnt.ToString();
            coincnt++;
            Destroy(coin);
         
        }
    }
}
