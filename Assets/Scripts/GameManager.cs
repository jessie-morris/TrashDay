using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float timeToNextScene = 10f;
    private float timeElapsed = 0f;
    private bool trashShopping = false;

    private bool hardDriveAquired = false;
    private bool notebookAquired = false;
    private bool photoAquired = false;
    private bool collarAquired = false;
    private bool mascotAquired = false;

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
            UnityEngine.SceneManagement.SceneManager.LoadScene("MidgameMenuScene");
        }

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

    public bool IsMascotAquired()
    {
        return mascotAquired;
    }
}