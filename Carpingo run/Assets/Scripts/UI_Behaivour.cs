using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Behaivour : MonoBehaviour
{
    public Text orangeText;
    public playerMovement pm;

    void Start()
    {
        pm = FindObjectOfType<playerMovement>();
        pm.loadData();
        orangeText.text = pm.previousInt.ToString();
    }

    void Update()
    {
        
    }
}
