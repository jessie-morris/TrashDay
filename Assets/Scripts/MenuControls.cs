using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartGame_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StoryScene");
    }

    public void CleanupTime_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InstructionsScene");
    }

    public void Ok_OnClick()
    {
        Debug.Log("hmm");
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

    public void Back_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MidgameMenuScene");
    }
}
