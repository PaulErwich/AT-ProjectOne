using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TextBoxManager : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public GameObject selectedShape;

    //Dictionary<ShapeType, string> areaDescriptions = new Dictionary<ShapeType, string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textBox = this.GetComponentInChildren<TextMeshProUGUI>();
        selectedShape = GameManager.instance.selectedShape;


        //areaDescriptions.Add(ShapeType.Cube, "The area of a cube is calculated by Width x Height.");
    }

    // Update is called once per frame
    void Update()
    {
        //float length = selectedShape.GetComponent<BoxScript>().length;
        textBox.text = selectedShape.GetComponent<Shape>().info.areaCalculation;
    }
}


