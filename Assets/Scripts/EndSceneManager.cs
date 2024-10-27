using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField] private TMP_Text storyText;
    string storyString =
    @"You call Kayla and tell her the good news. She's ecstatic and can't wait to see you. You both agree to meet at the park.

    Now you finally have enough money to start a family and maybe start a business that can further help clean up your city.

    Thanks for playing!

    Credits:
    Jessie Morris - www.github.com/jessiemorris
    Jake Rutter - https://jakerutter.itch.io/";


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowStory());
    }

    IEnumerator ShowStory()
    {
        AudioManager.instance.Play("keyboard");
        foreach (char c in storyString)
        {
            yield return new WaitForSeconds(0.05f);
            storyText.text += c;
        }
        AudioManager.instance.Stop("keyboard");
    }
}
