using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;

   public void EndGame()
    {
       if (FindObjectOfType<PlayerController>().gameOver == true)
        {
            Invoke("Restart", restartDelay);
        }
    }

    
    void Restart()
    {
        SceneManager.LoadScene("GameOver");
    }
}
