using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartGame_OnClick()
    {
        StartCoroutine(LoadScene("StoryScene"));
    }

    public void CleanupTime_OnClick()
    {
        StartCoroutine(LoadScene("InstructionsScene"));
    }

    public void Ok_OnClick()
    {
        StartCoroutine(LoadScene("CleanupScene"));
    }

    public void Back_OnClick()
    {
        StartCoroutine(LoadScene("MidgameMenuScene"));
    }

    public void SearchDumpsters_OnClick()
    {
        StartCoroutine(LoadScene("TrashShopScene"));
    }

    public void Hints_OnClick()
    {
        StartCoroutine(LoadScene("HintsScene"));
    }

    public void Computer_OnClick()
    {
        StartCoroutine(LoadScene("ComputerScene"));
    }

    public void EarnCredits_OnClick()
    {
        GameManager.instance.resetTimeElapsed();
        StartCoroutine(LoadScene("CleanupScene"));
    }

    public void EndGame_OnClick()
    {
        StartCoroutine(LoadScene("EndScene"));
    }

    public void ExitGame_OnClick()
    {
        Application.Quit();
    }

    IEnumerator LoadScene(string sceneName)
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.15f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

}
