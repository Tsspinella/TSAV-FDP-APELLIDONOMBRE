using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public static bool JuegoPausado = false;
    public GameObject pausemenuUI;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoPausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        JuegoPausado = false;
    }

    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        JuegoPausado = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}