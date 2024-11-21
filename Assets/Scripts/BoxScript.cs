using UnityEngine;
using Vuforia;

public class BoxScript : MonoBehaviour
{
    public Animator animator;

    ObserverBehaviour observerBehaviour;
    public bool Enable;

    public GameObject arrow;
    public float length;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        //arrow = transform.Find("Arrow").gameObject;
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
        Enable = animator.GetBool("Enabled");
    }
    private void OnMouseDown()
    {
        animator.SetBool("Enabled", true);
    }

    public void PlayBoxAnimation()
    {
        bool enabled = animator.GetBool("Enabled");
        animator.SetBool("Enabled", !enabled);

        arrow.SetActive(enabled);
    }

    public void ShowArrow()
    {
        arrow.SetActive(true);
    }
    public void HideArrow()
    {
        arrow.SetActive(false);
    }
}
