using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text consoleText;
    [SerializeField] private TMP_Text passwordPrompt;
    [SerializeField] private TMP_Text inputResponseText;
    [SerializeField] private TMP_InputField passwordInput;

    private int attemptCount = 0;
    private bool lockedOut = false;
    private bool booted = false;

    void Update()
    {
        if (!GameManager.instance.IsHardDriveAquired())
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
            if (Input.GetKeyDown(KeyCode.Return) && !lockedOut)
            {
                string cleanedPassword = passwordInput.text.ToLower().Replace(" ", "");
                bool passwordMatch = Base64Encode(cleanedPassword) == "YW5jaG9yYmFuZGl0aXRhbHlrYXlsYQ==";
                Debug.Log(passwordMatch);
                Debug.Log(Base64Encode(cleanedPassword));

                if (passwordMatch)
                {
                    inputResponseText.text += "\nAccess Granted!";
                    inputResponseText.text += "\nBitcoin balance: 101.393 BTC.";
                }
                else if (attemptCount < 3)
                {
                    attemptCount++;
                    inputResponseText.text += "Invalid Password!\n";

                    if (attemptCount == 3)
                    {
                        inputResponseText.text += "Too many attempts. Locked out.";
                        lockedOut = true;
                    }
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
        passwordPrompt.text += "Enter Password: ";

        passwordInput.gameObject.SetActive(true);
        passwordInput.Select();
    }

    public static string Base64Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }
}
