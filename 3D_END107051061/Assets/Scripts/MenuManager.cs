using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void StartGame()
    { 
        print("開始");
        SceneManager.LoadScene("場景");
        
    }
    void QuitGame()
    {
        print("結束");
        Application.Quit();
    }
}
