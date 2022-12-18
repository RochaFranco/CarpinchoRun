using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxBasico : MonoBehaviour
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
            Invoke("Spawn", velocidadDeSpawnDeObjetos - 0.5f);
        }
        else if (pm.KmRecorridos >= 50)
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos - 0.7f);
        }
        else if (pm.KmRecorridos < 25)
        {
            Invoke("Spawn", velocidadDeSpawnDeObjetos);
        }
    }

}
