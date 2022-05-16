using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Members : MonoBehaviour
{
    public GameObject Memb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Memb.SetActive(true);
        }
    } private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Memb.SetActive(false);
        }
    }
}
