using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject infoPanel;
    public Button dimensionButton;
    public Button areaButton;
    public Button perimeterButton;
    public Button surfaceAreaButton;
    public Button volumeButton;
    public TextMeshProUGUI trackedObject;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        infoPanel = GameObject.Find("InfoPanel");
        dimensionButton = GameObject.Find("ChangeDimension").GetComponent<Button>();
        areaButton = GameObject.Find("ShowArea").GetComponent<Button>();
        perimeterButton = GameObject.Find("ShowPerimeter").GetComponent<Button>();
        surfaceAreaButton = GameObject.Find("ShowSurfaceArea").GetComponent<Button>();
        volumeButton = GameObject.Find("ShowVolume").GetComponent<Button>();
        trackedObject = GameObject.Find("TrackedObject").GetComponent<TextMeshProUGUI>();

        dimensionButton.onClick.AddListener(ToggleObjectDimension);

        areaButton.onClick.AddListener(() => ActivatePanel(InfoType.area));
        areaButton.onClick.AddListener(() => ToggleTextInBox(InfoType.area));

        perimeterButton.onClick.AddListener(() => ActivatePanel(InfoType.perimeter));
        perimeterButton.onClick.AddListener(() => ToggleTextInBox(InfoType.perimeter));

        surfaceAreaButton.onClick.AddListener(() => ActivatePanel(InfoType.surfaceArea));
        surfaceAreaButton.onClick.AddListener(() => ToggleTextInBox(InfoType.surfaceArea));

        volumeButton.onClick.AddListener(() => ActivatePanel(InfoType.volume));
        volumeButton.onClick.AddListener(() => ToggleTextInBox(InfoType.volume));

        trackedObject.text = "Current Tracked Object:\nNone";

        surfaceAreaButton.gameObject.SetActive(false);
        volumeButton.gameObject.SetActive(false);
    }

    void ActivatePanel(InfoType type)
    {
        TextBoxManager.instance.TogglePanel(type);
    }

    void ToggleTextInBox(InfoType type)
    {
        TextBoxManager.instance.ToggleTextInBox(type);
    }

    void ToggleObjectDimension()
    {
        GameManager.instance.ToggleObjectDimension();
        areaButton.gameObject.SetActive(!areaButton.gameObject.activeInHierarchy);
        perimeterButton.gameObject.SetActive(!perimeterButton.gameObject.activeInHierarchy);
        surfaceAreaButton.gameObject.SetActive(!surfaceAreaButton.gameObject.activeInHierarchy);
        volumeButton.gameObject.SetActive(!volumeButton.gameObject.activeInHierarchy);
    }

    public void UpdateTrackedObject(GameObject _obj)
    {
        trackedObject.text = "Current Tracked Object:\n" + _obj.name;
    }
}
