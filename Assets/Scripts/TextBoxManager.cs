using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TextBoxManager : MonoBehaviour
{
    public GameObject trackedShape;
    public GameObject boxHeader;
    public GameObject boxBody;
    private TextMeshProUGUI textBody;
    private TextMeshProUGUI textHeader;

    public static TextBoxManager instance;
    public Animator animator;
    //Dictionary<ShapeType, string> areaDescriptions = new Dictionary<ShapeType, string>();

    // True for Area, false for Volume
    public bool textType;
    public bool active;
    public InfoType currentType = InfoType.none;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        //textBox = GameObject.findchi     GetComponentInChildren<TextMeshProUGUI>();
        trackedShape = GameManager.instance.trackedShape;
        animator = this.GetComponent<Animator>();

        boxHeader.SetActive(false);
        boxBody.SetActive(false);

        textHeader = boxHeader.GetComponent<TextMeshProUGUI>();
        textBody = boxBody.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTrackedObject(GameObject _obj)
    {
        trackedShape = _obj;
        ToggleTextInBox(currentType);
    }

    public void ToggleTextInBox(InfoType type)
    {
        Debug.Log("Toggle text" + type.ToString());
        currentType = type;
        switch(type)
        {
            case InfoType.area:
                textHeader.text = "Area";
                textBody.text = trackedShape.GetComponent<Shape>().info.areaCalculation;
                break;
            case InfoType.surfaceArea:
                textHeader.text = "Surface Area";
                textBody.text = trackedShape.GetComponent<Shape>().info.surfaceAreaCalculation;
                break;
            case InfoType.volume:
                textHeader.text = "Volume";
                textBody.text = trackedShape.GetComponent<Shape>().info.volumeCalculation;
                break;
            default:
                textHeader.text = "Invalid Info";
                break;
        }
    }

    public void ShowPanel()
    {
        active = true;
        animator.SetBool("Activate", true);
    }

    public void HidePanel()
    {
        active = false;
        animator.SetBool("Activate", false);
    }

    public void TogglePanel(InfoType type)
    {
        if (!active)
        {
            active = true;
            animator.SetBool("Activate", true);
        }
        else if (type == currentType)
        {
            active = false;
            animator.SetBool("Activate", false);
        }
        Debug.Log("Toggle panel");
    }

    public void ShowHeader()
    {
        boxHeader.SetActive(true);
    }

    public void HideHeader()
    {
        boxHeader.SetActive(false);
    }

    public void ShowBody()
    {
        boxBody.SetActive(true);
    }

    public void HideBody()
    {
        boxBody.SetActive(false);
    }
}

public enum InfoType
{
    none,
    area,
    surfaceArea,
    volume
}


