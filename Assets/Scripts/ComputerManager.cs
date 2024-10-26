using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text consoleText;
    [SerializeField] private TMP_InputField passwordInput;

    private bool booted = false;
    // Update is called once per frame
    void Update()
    {
        // if (!GameManager.instance.IsHardDriveAquired())
        if (false)
        {
            consoleText.text = "Error: No Hard Drive found!";
        }
        else if (booted == false)
        {
            booted = true;
            StartCoroutine(BootSequence());
        }
        if (booted == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (passwordInput.text == "correctPassword")
                {
                    consoleText.text += "\nAccess Granted!";
                    consoleText.text += "\nBitcoin balance: 101.393 BTC.";
                }
                else
                {
                    consoleText.text += "\nInvalid Password!";
                }
            }
        }
    }

    IEnumerator BootSequence()
    {
        consoleText.text = "Booting up...";
        yield return new WaitForSeconds(2);
        consoleText.text += "\nLoading OS...";
        yield return new WaitForSeconds(2);
        consoleText.text += "\nOS Loaded!";
        yield return new WaitForSeconds(2);
        consoleText.text += "\nAttempting to access bitcoin wallet...";
        yield return new WaitForSeconds(2);
        consoleText.text += "\nEnter Password: ";

        passwordInput.gameObject.SetActive(true);
    }
}
