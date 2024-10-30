using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TextBoxManager : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public GameObject selectedShape;

    public static TextBoxManager instance;
    //Dictionary<ShapeType, string> areaDescriptions = new Dictionary<ShapeType, string>();

    // True for Area, false for Volume
    public bool textType;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        textBox = this.GetComponentInChildren<TextMeshProUGUI>();
        selectedShape = GameManager.instance.selectedShape;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //areaDescriptions.Add(ShapeType.Cube, "The area of a cube is calculated by Width x Height.");
    }

    // Update is called once per frame
    void Update()
    {
        //float length = selectedShape.GetComponent<BoxScript>().length;
        //textBox.text = selectedShape.GetComponent<Shape>().info.areaCalculation;
    }

    public void ToggleTextInBox(bool b)
    {
        if (b)
            textBox.text = selectedShape.GetComponent<Shape>().info.areaCalculation;
        else
            textBox.text = selectedShape.GetComponent<Shape>().info.volumeCalculation;
    }
}


