using UnityEngine;

public class Wall_BreakAble : MonoBehaviour
{
    
    [SerializeField] private string requiredObjectTag = "Hands";


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(requiredObjectTag))
        {
            Debug.Log("Wall");
            DestroyWall();

        }

    }
    void DestroyWall()
    {
        Debug.LogError("DestroyWall");
        gameObject.SetActive(false);
    }

}
