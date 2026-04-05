using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverScreen;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            EnableGameOverScreen();
        }
    }

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

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Quit()
    {

        Application.Quit();

    }

}
