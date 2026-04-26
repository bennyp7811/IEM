using UnityEngine;


using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;

    // Load scene (Start button)
    public void LoadSceneButton()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Quit game (Exit button)
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // shows in editor
        Application.Quit();
    }
}
