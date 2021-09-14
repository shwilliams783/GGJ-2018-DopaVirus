using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Respawn());
    }   

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
