using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject infoPanel;
    public Button areaButton;
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
        areaButton = GameObject.Find("ShowArea").GetComponent<Button>();
        surfaceAreaButton = GameObject.Find("ShowSurfaceArea").GetComponent<Button>();
        volumeButton = GameObject.Find("ShowVolume").GetComponent<Button>();
        trackedObject = GameObject.Find("TrackedObject").GetComponent<TextMeshProUGUI>();

        areaButton.onClick.AddListener(() => ActivatePanel(InfoType.area));
        areaButton.onClick.AddListener(() => ToggleTextInBox(InfoType.area));

        surfaceAreaButton.onClick.AddListener(() => ActivatePanel(InfoType.surfaceArea));
        surfaceAreaButton.onClick.AddListener(() => ToggleTextInBox(InfoType.surfaceArea));

        volumeButton.onClick.AddListener(() => ActivatePanel(InfoType.volume));
        volumeButton.onClick.AddListener(() => ToggleTextInBox(InfoType.volume));

        trackedObject.text = "Current Tracked Object:\nNone";
    }

    void ActivatePanel(InfoType type)
    {
        TextBoxManager.instance.TogglePanel(type);
    }

    void ToggleTextInBox(InfoType type)
    {
        TextBoxManager.instance.ToggleTextInBox(type);
    }

    public void UpdateTrackedObject(GameObject _obj)
    {
        trackedObject.text = "Current Tracked Object:\n" + _obj.GetComponent<Shape>().info.type.ToString();
    }
}
