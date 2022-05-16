using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffer : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("dfg");
        }  if (Input.GetKeyUp(KeyCode.E))
        {
            anim.Play("tyr");
        }

    }
}
