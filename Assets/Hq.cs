using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hq : MonoBehaviour
{

    public float range = 1.4f;
    public Camera fpsCam;
    public float damage = 1f;
    public Text sd;
   
    public int fishcnt;
    public void Start()
    {

        

    }

    public void Update()
    {
        sd.text = fishcnt.ToString();
        if (Input.GetMouseButtonDown(1))
        {



            Buy_Sold();


        }

    }
   public void Buy_Sold()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
           Fish fish= hit.transform.GetComponent<Fish>();
            if (fish != null)
            {
                fish.TakeDamage(damage);
                fishcnt++;
            }
        }

    }
}
