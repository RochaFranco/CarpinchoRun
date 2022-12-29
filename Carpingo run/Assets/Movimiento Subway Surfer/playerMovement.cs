using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{

    public string myIntKey = "myInt";
    public int currentInt;
    public int previousInt;

    public Transform carrilesParent;
    public Transform[] carrilesPositions;
    public Transform carrilPositionActual;
    public int carrilActualIndex = 1; //carriles 0, 1 y 2
    public float playerHorizontalSpeed=10f;
    public GameObject cartelDePerder;
    public Text itemTexto;
    public Text kmTexto;
    public float KmRecorridos = 0;
    public int itemsTotales;
    public int items;



    private void Awake()
    {
        loadData();
    }

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
        Time.timeScale = 1f;

        carrilesPositions = new Transform[carrilesParent.childCount];
        for (int i = 0; i < carrilesParent.childCount; i++)
        {
            carrilesPositions[i] = carrilesParent.GetChild(i);
        }

        carrilPositionActual = carrilesPositions[carrilActualIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (carrilActualIndex > 0)
            {
                carrilActualIndex--;            
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (carrilActualIndex < carrilesPositions.Length-1)
            {
                carrilActualIndex++;
            }
        }
        carrilPositionActual = carrilesPositions[carrilActualIndex];

        transform.position = Vector3.MoveTowards(transform.position,carrilPositionActual.position,playerHorizontalSpeed*Time.deltaTime);



    }

    public void itemConseguido()
    {
        items++;
        itemTexto.text = items.ToString();
    }

    public void kmRecorrido()
    {
        KmRecorridos++;
        kmTexto.text = KmRecorridos.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Naranja")
        {
            itemConseguido();
            Destroy(other.gameObject);
        }

        if (other.tag == "Rock")
        {
            saveDate();
            Destroy(gameObject);
            cartelDePerder.SetActive(true);

            Time.timeScale = 0f;
        }

        if (other.tag == "Km")
        {
            kmRecorrido();
        }

    }

    public void saveDate()
    {
        currentInt = items + previousInt;
        PlayerPrefs.SetInt(myIntKey, currentInt);

    }

    public void loadData()
    {
        bool result = PlayerPrefs.HasKey(myIntKey);
        if (result)
        {
            previousInt = PlayerPrefs.GetInt(myIntKey);

        }
    }


}
