using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;

    [SerializeField]
    private AudioClip clip;

    public void PlayAudio()
    {
       
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
