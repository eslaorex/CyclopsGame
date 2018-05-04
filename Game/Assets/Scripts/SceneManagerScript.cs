using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            //gameHasEnded == true;
            Invoke("Restart", restartDelay);

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




	
}
