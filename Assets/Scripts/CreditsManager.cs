using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    private int credits = 0;
    [SerializeField] private Animator newCreditsAnimator;
    [SerializeField] private Animator totalCreditsAnimator;

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
        StartCoroutine(AnimateCreditsText());
    }

    IEnumerator AnimateCreditsText()
    {
        if (newCreditsAnimator != null)
        {
            newCreditsAnimator.SetBool("AddCredits", true); //show score being added
            yield return new WaitForSeconds(.3f);
            if (totalCreditsAnimator != null)
            {
                totalCreditsAnimator.SetBool("GrowCredits", true); //emphasize score
                yield return new WaitForSeconds(1);
                
                if (newCreditsAnimator != null && totalCreditsAnimator != null)
                {
                    totalCreditsAnimator.SetBool("GrowCredits", false); //reset
                    newCreditsAnimator.SetBool("AddCredits", false); //reset
                }
            }
        }
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
