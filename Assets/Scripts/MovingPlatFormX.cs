using UnityEngine;

public class MovingPlatformX : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("How far the platform moves up and down")]
    public float moveDistance = 3f;
    
    [Tooltip("How fast the platform moves")]
    public float speed = 2f;
    
    private Vector3 startPosition;
    
    void Start()
    {
        // Remember where the platform started
        startPosition = transform.position;
    }
    
    void Update()
    {
        // Calculate the new Z position using a sine wave
        float newX = startPosition.x + Mathf.Sin(Time.time * speed) * moveDistance;
        
        // Move the platform
        transform.position = new Vector3(startPosition.x, newX, startPosition.z);
    }
}