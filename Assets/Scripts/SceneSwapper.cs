using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
   
    float timer = 5f;
    bool isCounting = false;

    void Start()
    {
        StartTimer();
    }
    void StartTimer()
    {
        isCounting = true;
    }

    void Update()
    {
        if (!isCounting) return;

        timer -= Time.deltaTime;

        Debug.Log("Time remaining: " + Mathf.Ceil(timer)); // optional

        if (timer <= 0f)
        {
            isCounting = false;
            SceneManager.LoadScene("SampleScene");
            //SceneManager.LoadScene(0);
        }
    }



}
