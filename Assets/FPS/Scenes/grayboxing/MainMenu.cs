using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
  
    public void PlayAgain()
    {
        SceneManager.LoadScene("ExteriorLevel");
    }
}
