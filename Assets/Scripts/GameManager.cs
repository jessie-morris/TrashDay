using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float timeToNextScene = 45f;
    private float timeElapsed = 0f;
    private bool trashShopping = false;

    private bool hardDriveAquired = false;
    private bool notebookAquired = false;
    private bool photoAquired = false;
    private bool collarAquired = false;
    private bool vacationAquired = false;

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

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeToNextScene && !trashShopping)
        {
            trashShopping = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MidgameMenuScene");
        }

    }

    public void SetHardDriveAquired()
    {
        hardDriveAquired = true;
    }

    public void SetNotebookAquired()
    {
        notebookAquired = true;
    }

    public void SetPhotoAquired()
    {
        photoAquired = true;
    }

    public void SetCollarAquired()
    {
        collarAquired = true;
    }

    public void SetVacationAquired()
    {
        vacationAquired = true;
    }

    public bool IsHardDriveAquired()
    {
        return hardDriveAquired;
    }

    public bool IsNotebookAquired()
    {
        return notebookAquired;
    }

    public bool IsPhotoAquired()
    {
        return photoAquired;
    }

    public bool IsCollarAquired()
    {
        return collarAquired;
    }

    public bool IsVacationAquired()
    {
        return vacationAquired;
    }

    public void resetTimeElapsed()
    {
        timeElapsed = 0f;
        trashShopping = false;
    }
}