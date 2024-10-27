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

    public void SearchDumpsters_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TrashShopScene");
    }
    public void Hints_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HintsScene");
    }
    public void Computer_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ComputerScene");
    }

    public void EarnCredits_OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

}
