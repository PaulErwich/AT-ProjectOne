using UnityEngine;
using System;
using System.Collections.Generic;

public class TwoDShape : MonoBehaviour
{
    [SerializeField]
    public TwoDShapeInfo info;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.LookAt(GameManager.instance.ARCamera.transform);
    }

    public virtual float GetArea()
    {
        return 0;
    }

    public virtual float GetPerimeter()
    {
        return 0;
    }
}

[Serializable]
public class TwoDShapeInfo
{
    public TwoDShapeType type;
    public string areaCalculation;
    public string perimeterCalculation;
    public List<LengthPair> lengths = new List<LengthPair>();
}

public enum TwoDShapeType
{
    Square,
    Rectangle,
    Circle,
    Triangle
}