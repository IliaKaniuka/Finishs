using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class An : MonoBehaviour
{
   public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim.SetTrigger("hit");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>();
        if (Input.GetMouseButtonDown(0))
        {

        }   if (Input.GetMouseButtonUp(0))
        {

            anim.SetTrigger("ith");
        }
       
    }
}
