using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverScreen;


    private void OnEnable()
    {

        Player.OnPlayerDeath += EnableGameOverScreen;


    }

    private void OnDisable()
    {

        Player.OnPlayerDeath -= EnableGameOverScreen;

    }

    public void EnableGameOverScreen()
    {

        gameOverScreen.SetActive(true);

    }

    public void RestartGame()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Quit()
    {

        Application.Quit();

    }

}
