using UnityEngine;
using System;
using System.Collections.Generic;

public class Shape : MonoBehaviour
{
    [SerializeField]
    public ShapeInfo info;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        info.areaCalculation += $"\nIn this case that would be {info.lengths[0].value} x {info.lengths[1].value} = {info.lengths[0].value * info.lengths[1].value}";
        info.volumeCalculation += $"\nIn this case that would be {info.lengths[0].value} x " +
            $"{info.lengths[1].value} x {info.lengths[2].value} = {info.lengths[0].value * info.lengths[1].value * info.lengths[2].value}.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class ShapeInfo
{
    public ShapeType type;
    public string areaCalculation;
    public string volumeCalculation;
    public List<LengthPair> lengths = new List<LengthPair>();
}
public enum ShapeType
{
    Cube,
    Sphere,
}

public enum LengthType
{
    width,
    height,
    depth
}
[Serializable]
public struct LengthPair
{
    public LengthType type;
    public float value;
}