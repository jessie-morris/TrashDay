using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    private int credits = 0;

    public static CreditsManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddToScore(int points)
    {
        credits += points;
    }
    public void DeductFromScore(int points)
    {
        credits -= points;
    }
    public int GetCredits()
    {
        return credits;
    }
}
