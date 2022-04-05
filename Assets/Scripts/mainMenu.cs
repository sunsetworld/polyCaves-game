using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas settingsCanvas;
    [SerializeField] AudioSource aS;
    [SerializeField] AudioClip menu1;
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
        AudioSource.PlayClipAtPoint(menu1, transform.position);
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        AudioSource.PlayClipAtPoint(menu1, transform.position);
        Application.Quit();
    }

    public void goToMainMenu()
    {
        AudioSource.PlayClipAtPoint(menu1, transform.position);
        SceneManager.LoadScene(0);
    }

    public void easy()
    {
        AudioSource.PlayClipAtPoint(menu1, transform.position);
        SceneManager.LoadScene(1);
    }

    public void medium()
    {
        SceneManager.LoadScene(2);
    }
    public void hard()
    {
        AudioSource.PlayClipAtPoint(menu1, transform.position);
        SceneManager.LoadScene(3);
    }
}
