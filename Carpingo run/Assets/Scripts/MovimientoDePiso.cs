using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDePiso : MonoBehaviour
{
    public Renderer materialPiso;
    public float scrollSpeed;
    private float offset;
    private playerMovement pm;

    private void Start()
    {
        pm = FindObjectOfType<playerMovement>();
    }

    void Update()
    {

        if (pm.KmRecorridos < 25)
        {
            offset += (Time.deltaTime * scrollSpeed) / 10f;
            materialPiso.material.mainTextureOffset = new Vector2(0, -offset);
        }
        else if (pm.KmRecorridos >= 25 && pm.KmRecorridos < 100)
        {
            offset += (Time.deltaTime * scrollSpeed) / 6.7f;
            materialPiso.material.mainTextureOffset = new Vector2(0, -offset);
        }
        else if (pm.KmRecorridos >= 100)
        {
            offset += (Time.deltaTime * scrollSpeed) / 5f;
            materialPiso.material.mainTextureOffset = new Vector2(0, -offset);
        }

    }
}
