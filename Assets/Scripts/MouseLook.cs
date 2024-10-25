using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 1f;

    [SerializeField]
    private Transform playerBody;

    private Vector3 lookRotation;
    private Vector3 mouseDelta;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        UpdateInput();

        lookRotation.x -= mouseDelta.y * mouseSensitivity;
        lookRotation.y += mouseDelta.x * mouseSensitivity;
        lookRotation.x = Mathf.Clamp(lookRotation.x, -89f, 89f);

        transform.localRotation = Quaternion.Euler(lookRotation.x, 0, 0);

        Vector3 forward = Quaternion.AngleAxis(lookRotation.y, Vector3.up) * Vector3.forward;
        playerBody.rotation = Quaternion.LookRotation(forward, Vector3.up);
    }

    private void UpdateInput()
    {
        mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }
}
