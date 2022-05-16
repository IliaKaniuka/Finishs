using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointEnter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
{
    public float k = 1.08f;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter Received");
        transform.localScale /= k;
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        transform.localScale *= k;
    }
    
   
    void Start()
    {
        
    }


    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Vector3 targetMousePosition = new Vector3(mouseRay.direction.x, mouseRay.direction.y * 1.2f, mouseRay.direction.z);

        transform.LookAt(targetMousePosition);
    }
}
