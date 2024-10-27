using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartGame_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("StoryScene");
    }

    public void CleanupTime_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("InstructionsScene");
    }

    public void Ok_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

    public void Back_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MidgameMenuScene");
    }

    public void SearchDumpsters_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("TrashShopScene");
    }
    public void Hints_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("HintsScene");
    }
    public void Computer_OnClick()
    {
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("ComputerScene");
    }

    public void EarnCredits_OnClick()
    {
        GameManager.instance.resetTimeElapsed();
        AudioManager.instance.PlayOneShot("Click");
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

}
