using UnityEngine;

public class CameraRigMovement : MonoBehaviour
{


    public Transform target;
    public float FollowSpeed = 2f;


    void Update()
    {
        Vector3 newpos = new Vector3(target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, FollowSpeed*Time.deltaTime);
           
        
    }
}