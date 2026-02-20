using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;

    void Update()
    {
        float smoothY = Mathf.Lerp(transform.position.y, player.position.y, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, smoothY, transform.position.z);
    }
}