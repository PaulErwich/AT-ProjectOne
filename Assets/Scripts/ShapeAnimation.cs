using UnityEngine;

public class ShapeAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject arrows;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        bool enabled = animator.GetBool("Enabled");
        animator.SetBool("Enabled", !enabled);

        arrows.SetActive(enabled);
    }
}
