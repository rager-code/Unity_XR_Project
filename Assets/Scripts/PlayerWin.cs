using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWin : MonoBehaviour
{
    

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("PlayerWin"))
        {
            SceneManager.LoadScene(1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }



}
