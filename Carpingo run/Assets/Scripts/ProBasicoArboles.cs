using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProBasicoArboles : MonoBehaviour
{
    public GameObject[] objetosPosibles;
    public float velocidadDeSpawnDeObjetos;
    public playerMovement pm;

    void Start()
    {
        pm = FindObjectOfType<playerMovement>();
        Spawn();

    }

    void Spawn()
    {
        Instantiate(
            objetosPosibles[Random.Range(0, objetosPosibles.Length)],
            transform.position,
            Quaternion.identity
            );


        if (pm.KmRecorridos >= 25 && pm.KmRecorridos < 50)
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos - 3.2f);
        }
        else if (pm.KmRecorridos >= 50)
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos - 4.9f);
        }
        else if (pm.KmRecorridos <= 25)
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos);
        }
        else
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos);
        }
    }
}
