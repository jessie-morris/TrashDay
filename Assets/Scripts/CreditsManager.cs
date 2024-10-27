using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    private int credits = 0;
    [SerializeField] private Animator newCreditsAnimator;
    [SerializeField] private Animator totalCreditsAnimator;
    [SerializeField] private TextMeshProUGUI addedCreditsText;

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
            addedCreditsText.color = Color.white;
            addedCreditsText.text = "+150";
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
        credits = Mathf.Max(0, credits - points);
        
        StartCoroutine(AnimateCreditsText_Subtraction());
    }

     IEnumerator AnimateCreditsText_Subtraction()
    {
        if (newCreditsAnimator != null)
        {
            addedCreditsText.text = "-50";
            addedCreditsText.color = Color.red;
            newCreditsAnimator.SetBool("AddCredits", true); //show score being subtracted (using same text and animator)

            yield return new WaitForSeconds(.3f);
            if (totalCreditsAnimator != null)
            {
                totalCreditsAnimator.SetBool("FlashRed", true); //emphasize negative score
                yield return new WaitForSeconds(1);

                if (newCreditsAnimator != null && totalCreditsAnimator != null)
                {
                    newCreditsAnimator.SetBool("AddCredits", false); //reset
                    totalCreditsAnimator.SetBool("FlashRed", false);
                }
            }
        }
    }

    public int GetCredits()
    {
        return credits;
    }
}
