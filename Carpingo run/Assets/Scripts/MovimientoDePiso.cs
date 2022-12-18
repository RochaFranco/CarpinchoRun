using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDePiso : MonoBehaviour
{
    public Renderer materialPiso;
    public float scrollSpeed;
    private float offset;

    private void Start()
    {

    }

    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        materialPiso.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
