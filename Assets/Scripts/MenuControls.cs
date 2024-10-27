using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartGame_OnClick()
    {
        StartCoroutine(LoadStoryScene());
    }

    IEnumerator LoadStoryScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("StoryScene");
    }

    public void CleanupTime_OnClick()
    {
        StartCoroutine(LoadInstructionsScene());
    }

    IEnumerator LoadInstructionsScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("InstructionsScene");
    }

    public void Ok_OnClick()
    {
        StartCoroutine(LoadCleanupScene());
    }

    IEnumerator LoadCleanupScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

    public void Back_OnClick()
    {
        StartCoroutine(LoadMidgameMenuScene());
    }

    IEnumerator LoadMidgameMenuScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MidgameMenuScene");
    }

    public void SearchDumpsters_OnClick()
    {
        StartCoroutine(LoadTrashShopScene());
    }

    IEnumerator LoadTrashShopScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("TrashShopScene");
    }

    public void Hints_OnClick()
    {
        StartCoroutine(LoadHintsScene());
    }

    IEnumerator LoadHintsScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("HintsScene");
    }

    public void Computer_OnClick()
    {
        StartCoroutine(LoadComputerScene());
    }

    IEnumerator LoadComputerScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("ComputerScene");
    }

    public void EarnCredits_OnClick()
    {
        GameManager.instance.resetTimeElapsed();
        StartCoroutine(LoadCleanupScene());
    }

    IEnumerator LoadCleanUpScene()
    {
        AudioManager.instance.PlayOneShot("Click");
        yield return new WaitForSeconds(.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("CleanupScene");
    }

}
