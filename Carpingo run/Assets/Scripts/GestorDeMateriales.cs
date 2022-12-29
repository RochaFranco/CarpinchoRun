using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorDeMateriales : MonoBehaviour
{
    public GameObject player;
    private playerMovement pm;
    public Material materialDefault;
    public Material materialBoquita;
    public static GameObject bloq;
    public static GameObject precio;
    public Renderer rend;
    public string bokitaComprado;
    public int skinSeleccionada;
    public string myStringBokita;
    public string myIntKey = "myInt";


    private void Start()
    {
        loadData();


        pm = FindObjectOfType<playerMovement>();

        if (skinSeleccionada == 0)
        {
            saveDataShop();
            loadData();
            rend.material = materialDefault;
        }
        else if (skinSeleccionada == 1)
        {
            saveDataShop();
            loadData();
            rend.material = materialBoquita;
        }

        if (bokitaComprado == "true")
        {
            saveDataShop();
            loadData();
            bloq = GameObject.Find("bokita_bloqueado");
            precio = GameObject.Find("bokita_precio");
            bloq.SetActive(false);
            precio.SetActive(false);

        }

    }


    public void Button_SkinDefault()
    {
        skinSeleccionada = 0;
        rend.material = materialDefault;
        saveDataShop();

    }

    public void Button_SkinBoquita()
    {
        skinSeleccionada = 1;   
        pm.loadData();
        bloq = GameObject.Find("bokita_bloqueado");
        precio = GameObject.Find("bokita_precio");
        saveDataShop();

        if ((bokitaComprado != "true"))
        {
            if (pm.previousInt > 1000)
            {
                pm.loadData();
                skinSeleccionada = 1;
                bloq.SetActive(false);
                precio.SetActive(false);
                pm.previousInt = pm.previousInt - 1000;
                pm.saveDate();
                rend.material = materialBoquita;
                bokitaComprado = "true";
                saveDataShop();
                
            }
            
        }
        else if (bokitaComprado == "true")
        {
            rend.material = materialBoquita;
            skinSeleccionada = 1;
            pm.loadData();
            pm.saveDate();
            saveDataShop();
        }

        saveDataShop();

    }

    public void saveDataShop()
    {
        PlayerPrefs.SetInt("XD", skinSeleccionada);
        PlayerPrefs.SetString(myStringBokita, bokitaComprado);
    }

    public void loadData()
    {
        bool result = PlayerPrefs.HasKey("XD");
        bool result2 = PlayerPrefs.HasKey(myStringBokita);


        if (result)
        {
            skinSeleccionada = PlayerPrefs.GetInt("XD");

        }

        if (result2)
        {
            bokitaComprado = PlayerPrefs.GetString(myStringBokita);

        }
    }
}
