using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public List<GameObject> ARShapes;
    public GameObject trackedShape;

    public GameObject ARCamera;

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
        ARShapes = new List<GameObject>(GameObject.FindGameObjectsWithTag("ARShape"));
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

    public void ToggleObjectDimension()
    {
        trackedShape.GetComponent<ShapeManager>().ToggleMode();
    }
}
