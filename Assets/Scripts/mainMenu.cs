using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas settingsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openSettings()
    {
        mainMenuCanvas.enabled = false;
        settingsCanvas.enabled = true;
    }

    public void closeSettings()
    {
        settingsCanvas.enabled = false;
        mainMenuCanvas.enabled = true;
    }

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
