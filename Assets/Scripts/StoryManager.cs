using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    [SerializeField] private TMP_Text storyText;
    [SerializeField] private Button startGameButton;
    string storyString =
    @"After waking up from a coma, you see that the bitcoin price has jumped from a humble eight dollars to over $60,000


Your landlord threw out your belongings including the harddrive containing 100 bitcoins!


After calling the city, they've allowed you to search for your lost harddrive on the condition you help clean up the city.


Clean up the city and dig through pieces of your past in the hope you'll find your fortune!";


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
        startGameButton.gameObject.SetActive(true);
    }
}
