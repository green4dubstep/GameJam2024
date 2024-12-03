using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen; // Drag a UI win screen here in the Inspector.

    public void WinGame()
    {
        Debug.Log("You Win!");

        // Show the win screen if it's assigned.
        if (winScreen != null)
        {
            winScreen.SetActive(true);
        }

        // Optionally load a different scene for the win screen.
        // SceneManager.LoadScene("WinScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the current scene.
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the application.
        Debug.Log("Game Quit!"); // Only visible in the editor.
    }
}
