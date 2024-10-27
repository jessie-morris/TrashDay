using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsText : MonoBehaviour
{
    [SerializeField] private TMP_Text creditsText;

    // Update is called once per frame
    void Update()
    {
        //creditsText.text = "Credits: " + CreditsManager.instance.GetCredits();
    }
}
