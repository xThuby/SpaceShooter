using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private Animator animator;

    private Camera mainCam;

    private NavMeshAgent agent;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();

        mainCam = Camera.main;

        agent = GetComponent<NavMeshAgent>();
    }

    public void SetDestination(Vector3 targetPosition)
    {
        agent.destination = targetPosition;
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
