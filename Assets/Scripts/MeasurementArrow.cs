using UnityEngine;

public class MeasurementArrow : MonoBehaviour
{
    float length;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        length = this.GetComponentInParent<BoxScript>().length;
        this.GetComponentInChildren<TextMesh>().text = length.ToString() + " CM";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
