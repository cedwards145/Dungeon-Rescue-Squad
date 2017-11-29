using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public float restartTimer = 3;
    private float timerStarted = Mathf.Infinity;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timerStarted + restartTimer)
        {
            ReloadScene();
        }
    }

    public void Restart()
    {
        timerStarted = Time.time;
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        timerStarted = Mathf.Infinity;
    }
}
