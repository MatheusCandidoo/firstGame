using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptControladorCena : MonoBehaviour
{
    private static bool carregado = false;
    public GameObject pc;
    // Update is called once per frame
    void Update()
    {
        if(pc == null)
        {
            carregaMenu();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (carregado)
            {
                descarregaMenu();
            }
            else
            {
                carregaMenu();
            }
        }
    }

    public static void carregaMenu()
    {

        SceneManager.LoadScene(0, LoadSceneMode.Additive);
        Time.timeScale = 0;
        carregado = true;
    }
    public static void descarregaMenu()
    {
        SceneManager.UnloadSceneAsync(0);
        Time.timeScale = 1;
        carregado = false;
    }
}
