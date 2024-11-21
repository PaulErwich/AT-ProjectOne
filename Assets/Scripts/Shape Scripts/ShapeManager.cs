using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    public GameObject threeDShape;
    public GameObject twoDShape;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        threeDShape.SetActive(false);
        twoDShape.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMode()
    {
        threeDShape.SetActive(!threeDShape.activeInHierarchy);
        twoDShape.SetActive(!twoDShape.activeInHierarchy);
    }
}

public enum ShapeMode
{
    TwoD,
    ThreeD
}