using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoDeObstaculos : MonoBehaviour
{
    public playerMovement pm;

    private void Start()
    {

        pm =  FindObjectOfType<playerMovement>();
    }

    void Update()
    {
        

        if (pm.KmRecorridos >= 25 && pm.KmRecorridos < 50)
        {
            transform.Translate(0, 0, -15 * Time.deltaTime);
        }
        else if (pm.KmRecorridos >= 50)
        {
            transform.Translate(0, 0, -20 * Time.deltaTime);
        }
        else if(pm.KmRecorridos < 25)
        {
            transform.Translate(0, 0, -10 * Time.deltaTime);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destructor")
        {
            Destroy(gameObject);
        }
    }


}
