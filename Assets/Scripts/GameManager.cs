using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] ARShapes;
    public GameObject trackedShape;

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
        textBox = GameObject.Find("InfoPanel").gameObject;
        //textBox.SetActive(false);
        showArea = GameObject.Find("ShowArea").gameObject.GetComponent<Button>();
        showVolume = GameObject.Find("ShowVolume").gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //showArea.GetComponent<Button>().onClick.AddListener(ToggleAreaCalculation);
    }

    public void UpdateTrackedObject(GameObject _obj)
    {
        trackedShape = _obj;
        UIManager.instance.UpdateTrackedObject(_obj);
        TextBoxManager.instance.trackedShape = _obj;
    }
}
