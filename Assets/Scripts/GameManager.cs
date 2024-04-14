using UnityEngine;
using UnityEngine.SceneManagement; // using for changing scenes , aka - game over , next level and etc

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart(); // Simple triggering restart on game over , but without delay
            Invoke("Restart", restartDelay); // Calling restart with delay of 1 seconds 
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart npw is look like just loading initial start point of current scene
    }
}
