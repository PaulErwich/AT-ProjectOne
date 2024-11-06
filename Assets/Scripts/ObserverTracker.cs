using UnityEngine;
using Vuforia;

public class ObserverTracker : MonoBehaviour
{
    ObserverBehaviour observerBehaviour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour != null)
            observerBehaviour.OnTargetStatusChanged += OnStatusChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED)
        {
            GameManager.instance.UpdateTrackedObject(transform.GetChild(0).gameObject);
        }
    }

    private void OnDestroy()
    {
        if (observerBehaviour != null)
            observerBehaviour.OnTargetStatusChanged -= OnStatusChanged;
    }
}
