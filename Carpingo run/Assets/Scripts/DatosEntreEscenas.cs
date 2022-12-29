using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEntreEscenas : MonoBehaviour
{
    public static DatosEntreEscenas instance;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
