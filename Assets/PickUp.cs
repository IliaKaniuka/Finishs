using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {



            Buy_Sold();


        }

    }
   private void Buy_Sold()
    {

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
          Coin coin = hit.transform.GetComponent<Coin>();
            if (coin != null)
            {
                coin.TakeCare(damage);
                fishcnt++;
            }
        }

    }
}
