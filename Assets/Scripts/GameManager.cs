using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TMP_Text scoreText;
    private int score = 0;

    private float timeToNextScene = 60f;
    private float timeElapsed = 0f;


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
        if (timeElapsed >= timeToNextScene)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SearcHScene");
        }
    }

    public void AddToScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
    public void DeductFromScore(int points)
    {
        score -= points;
        scoreText.text = "Score: " + score;
    }
}