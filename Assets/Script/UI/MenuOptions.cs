using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {

 public void LoadScene(int SceneToChangeTo)
    {
        SceneManager.LoadScene(SceneToChangeTo);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
