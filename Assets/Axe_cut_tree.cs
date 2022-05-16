using UnityEngine.Audio;
using UnityEngine.UI;
using System;
    using System.Collections.Generic;
using UnityEngine;


public class Axe_cut_tree : MonoBehaviour {
     Animator anim ;
   
 public float range = 1.4f;
public Camera fpsCam;
public float damage = 1f;
public Text st;
public int fishcnt;
public void Start()
{

      

    }

public void Update()
{
    st.text = fishcnt.ToString();
    if (Input.GetMouseButtonDown(0))
    {


            Buy_Sold();



        }

}
    void Buy_Sold()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Woodik woodik = hit.transform.GetComponent<Woodik>();
            if (woodik != null)
            {
                woodik.TakeDamage(damage);
                fishcnt++;
            }
        }

    }
}
