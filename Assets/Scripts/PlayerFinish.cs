using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFinish : MonoBehaviour
{
    public string menuSceneName = "Menu"; // ganti dengan nama scene kamu

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Player menyentuh koin! Kembali ke menu.");
            SceneManager.LoadScene(menuSceneName);
        }
    }
}
