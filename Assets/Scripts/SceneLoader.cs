using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneNameToLoad = "Main"; // ganti dengan nama scene tujuan kamu

    void Update()
    {
        // Tombol SPACE atau klik mouse → pindah scene
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }

        // Tombol ESC → keluar dari game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Keluar dari game...");
        }
    }
}
