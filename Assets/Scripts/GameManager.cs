using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float timeToNextScene = 10f;
    private float timeElapsed = 0f;
    private bool trashShopping = false;
    private bool hardDriveAquired = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeToNextScene && !trashShopping)
        {
            trashShopping = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("TrashShopScene");
        }

    }

    public bool IsHardDriveAquired()
    {
        return hardDriveAquired;
    }

    public void AquireHardDrive()
    {
        hardDriveAquired = true;
    }

}