using UnityEngine;

public class ParentMouseDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponentInParent<BoxScript>().PlayBoxAnimation();
        Debug.Log("Clicked side");
    }
}
