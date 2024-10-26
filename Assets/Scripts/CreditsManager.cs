using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    [SerializeField] TMP_Text creditsText;
    private int credits = 0;

    public static CreditsManager instance;

    void Awake()
    {
        if (instance == null)
        {
            Debug.Log("making a credit manager at: " + Time.time);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        creditsText.text = "Cleanup Credits: " + credits;
    }

    public void AddToScore(int points)
    {
        credits += points;
    }
    public void DeductFromScore(int points)
    {
        credits -= points;
    }
}
