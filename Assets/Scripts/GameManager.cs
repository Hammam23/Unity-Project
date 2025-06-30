using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int attemptCount = 1;
    public TextMeshProUGUI attemptsText;

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

    void Start()
    {
        UpdateAttemptsUI();
    }

    public void RestartLevel()
    {
        attemptCount++;
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;

        // Cari ulang attemptsText setelah scene dimuat ulang
        attemptsText = GameObject.Find("AttemptsText")?.GetComponent<TextMeshProUGUI>();
        UpdateAttemptsUI();
    }

    void UpdateAttemptsUI()
    {
        if (attemptsText != null)
        {
            attemptsText.text = "Attempts : " + attemptCount;
        }
    }
}
