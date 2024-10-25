using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    private Camera mainCam;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();

        mainCam = Camera.main;
    }

    private void FixedUpdate()
    {
        Vector3 camForward = mainCam.transform.forward;
        Vector3 forward = transform.forward;
        Vector3 right = transform.right;
        float rightDot = Vector3.Dot(right, camForward);
        float forwardDot = Vector3.Dot(forward, camForward);
        animator.SetFloat("rightDot", rightDot);
        animator.SetFloat("forwardDot", forwardDot);
    }
}
