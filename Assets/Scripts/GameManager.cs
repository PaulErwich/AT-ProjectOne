using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] ARShapes;
    public GameObject selectedShape;

    public GameObject textBox;
    public Button showArea;
    public Button showVolume;

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
        showVolume = GameObject.Find("ShowVolume").gameObject.GetComponent<Button>();

        showArea.onClick.AddListener(() => ToggleTextBox(true));
        showVolume.onClick.AddListener(() => ToggleTextBox(false));
    }

    // Update is called once per frame
    void Update()
    {
        //showArea.GetComponent<Button>().onClick.AddListener(ToggleAreaCalculation);
    }

    void ToggleTextBox(bool b)
    {
        textBox.SetActive(!textBox.activeInHierarchy);
        TextBoxManager.instance.ToggleTextInBox(b);
    }
}
