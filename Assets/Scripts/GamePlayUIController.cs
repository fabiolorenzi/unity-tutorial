using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    public void RestartGame()
    {
        // SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // this code here is more reusable
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }    
}
