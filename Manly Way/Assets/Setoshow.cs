using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setoshow : MonoBehaviour
{
    // Config
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] float levelExitSlowMoFactor = 0.2f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = levelExitSlowMoFactor;
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        Time.timeScale = 1f;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }
}
