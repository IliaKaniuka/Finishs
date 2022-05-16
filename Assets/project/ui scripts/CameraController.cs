using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Vector3 targetMousePosition = new Vector3(mouseRay.direction.x, mouseRay.direction.y * 1.2f, mouseRay.direction.z);

        transform.LookAt(targetMousePosition);
    }
}
