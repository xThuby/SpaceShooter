using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private Transform playerBody;

    private float lookY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        lookY += Input.GetAxis("Mouse X");

        playerBody.rotation = Quaternion.Euler(0, lookY, 0);
    }
}
