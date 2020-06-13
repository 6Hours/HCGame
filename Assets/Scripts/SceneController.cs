using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void OpenScene(string _sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(_sceneName);
    }
    public static void RestartScene()
    {
        OpenScene(SceneManager.GetActiveScene().name);
    }
}
