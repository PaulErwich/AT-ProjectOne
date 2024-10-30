using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] ARShapes;
    public GameObject selectedShape;

    public GameObject textBox;
    public Button showArea;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ARShapes = GameObject.FindGameObjectsWithTag("ARShape");
        textBox = GameObject.Find("Panel").gameObject;
        textBox.SetActive(false);
        showArea = GameObject.Find("ShowArea").gameObject.GetComponent<Button>();

        showArea.onClick.AddListener(ToggleAreaCalculation);
    }

    // Update is called once per frame
    void Update()
    {
        //showArea.GetComponent<Button>().onClick.AddListener(ToggleAreaCalculation);
    }

    void ToggleAreaCalculation()
    {
        //selectedShape.GetComponent<BoxScript>().ShowArrow();
        textBox.SetActive(!textBox.activeInHierarchy);
    }
}
