using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    { 
        print("開始");
        SceneManager.LoadScene("場景");
        
    }
    public void QuitGame()
    {
        print("結束");
        Application.Quit();

    }
    
}
