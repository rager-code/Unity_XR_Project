using UnityEngine;

public class YawPitchController : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float yawSpeed = 90f;   // Degrees per second (A key)
    private Vector3 lockedPosition;


    private void start()
    {
        //lockedPosition = transform.position;

    }
    void Update()
    {
        float yawInput = Input.GetAxis("Horizontal");
        float yaw = yawInput * yawSpeed * Time.deltaTime;

        transform.Rotate(0f, yaw, 0f, Space.Self);
    }
    void rotate()
    {
        

    }
}