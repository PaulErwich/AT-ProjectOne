using UnityEngine;
using Vuforia;

public class BoxScript : MonoBehaviour
{
    Animator animator;

    ObserverBehaviour observerBehaviour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Awake()
    {
        observerBehaviour = GetComponentInParent<ObserverBehaviour>();

       // if (observerBehaviour != null)
          //  observerBehaviour.OnTargetStatusChanged += OnStatusChanged();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        animator.SetBool("Enabled", true);
    }

    public void PlayBoxAnimation()
    {
        bool enabled = animator.GetBool("Enabled");
        animator.SetBool("Enabled", !enabled);
    }
}
