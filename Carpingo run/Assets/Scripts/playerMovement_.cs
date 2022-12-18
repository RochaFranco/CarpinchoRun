using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_ : MonoBehaviour
{
    public int posicion = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (posicion > -1)
            {
                gameObject.transform.position = new Vector3(transform.position.x +  -2.5f, transform.position.y, transform.position.z);
                posicion = posicion - 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (posicion < 1)
            {
                gameObject.transform.position = new Vector3(transform.position.x + 2.5f, transform.position.y, transform.position.z);
                posicion = posicion + 1;
            }
        }
    }
}
