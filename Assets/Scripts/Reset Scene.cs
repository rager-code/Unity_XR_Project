using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    //[SerializeField] private string requiredObjectTag = "PlayerKill";
    
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("PlayerKill"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }


   
}
