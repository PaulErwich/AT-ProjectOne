using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject infoPanel;
    public Button areaButton;
    public Button volumeButton;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        infoPanel = GameObject.Find("InfoPanel");
        areaButton = GameObject.Find("ShowArea").GetComponent<Button>();
        volumeButton = GameObject.Find("ShowVolume").GetComponent<Button>();

        InfoType tempType = InfoType.area;
        areaButton.onClick.AddListener(() => ActivatePanel(InfoType.area));
        areaButton.onClick.AddListener(() => ToggleTextInBox(InfoType.area));

        tempType = InfoType.volume;
        volumeButton.onClick.AddListener(() => ActivatePanel(InfoType.volume));
        volumeButton.onClick.AddListener(() => ToggleTextInBox(InfoType.volume));
    }

    void ActivatePanel(InfoType type)
    {
        TextBoxManager.instance.TogglePanel(type);
    }

    void ToggleTextInBox(InfoType type)
    {
        TextBoxManager.instance.ToggleTextInBox(type);
    }
}
