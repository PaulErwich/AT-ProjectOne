using UnityEngine;
using TMPro;
using Vuforia;

public class MoveCubeUp : MonoBehaviour
{
    public Vector3 position;
    public Vector3 origin;
    public TextMeshProUGUI tempUIPos;
    public TextMeshProUGUI tempUIOrigin;

    private ObserverBehaviour mObserverBehaviour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        origin = transform.position;
    }
    private void Awake()
    {
        mObserverBehaviour = GetComponentInParent<ObserverBehaviour>();

        if (mObserverBehaviour != null)
            mObserverBehaviour.OnTargetStatusChanged += OnStatusChanged;
    }

    // Update is called once per frame
    void Update()
    {
        //tempUIPos.text = this.gameObject.GetComponentInParent<DefaultObserverEventHandler>().TargetStatus;
        tempUIOrigin.text = "Position: X: " + position.x + " Y: " + position.y + " Z:" + position.z + "Origin: X: " + origin.x + " Y: " + origin.y + " Z: " + origin.z;
    }

    void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        tempUIPos.text = "TargetName: " + behaviour.TargetName + " Status is: " + status.Status.ToString() + " StatusInfo is: " + status.StatusInfo.ToString();
    }

    private void OnDestroy()
    {
        if (mObserverBehaviour != null)
            mObserverBehaviour.OnTargetStatusChanged -= OnStatusChanged;
    }

    private void OnMouseDown()
    {
        MoveCube();
    }

    public void MoveCube()
    {
        position = transform.position;
        position.y += 0.1f;
        transform.position = position;
    }

    public void ResetPosition()
    {
        position = origin;
        transform.position = origin;
    }
}
