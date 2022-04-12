using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    AsyncOperation l1;
    AsyncOperation l2;
    AsyncOperation l3;
    AsyncOperation l4;
    AsyncOperation l5;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            l1 = SceneManager.LoadSceneAsync(1);
            if (l1.isDone)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        reloadWithEscape();
    }

    private static void reloadWithEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex >= 1)
            {
                SceneManager.LoadScene(1);

            }
        }

    }

    public void goToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
