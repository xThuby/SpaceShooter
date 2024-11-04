using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float sensitivity;

    [SerializeField]
    private Transform playerBody;

    private Vector2 mouseInput;
    private Vector3 lookRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        UpdateInput();

        lookRotation.y += mouseInput.x * sensitivity;
        lookRotation.x -= mouseInput.y * sensitivity;

        lookRotation.x = Mathf.Clamp(lookRotation.x, -89, 89);

        playerBody.rotation = Quaternion.Euler(0, lookRotation.y, 0);
        transform.localRotation = Quaternion.Euler(lookRotation.x, 0, 0);
    }

    private void UpdateInput()
    {
        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }
}
