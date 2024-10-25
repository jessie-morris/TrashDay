using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TMP_Text scoreText;
    private int score = 0;

    private float timeToNextScene = 60f;
    private float timeElapsed = 0f;
    bool trashShopping = false;


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

        scoreText.text = "Cleanup Credits: " + score;
    }

    public void AddToScore(int points)
    {
        score += points;
    }
    public void DeductFromScore(int points)
    {
        score -= points;
    }


}