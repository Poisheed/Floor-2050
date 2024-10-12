using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
        //per applicare il cambio scena ad un pulsante richiamare sull' OnClick() la canva, aggiungere lo script SceneManagerScript 
        //e richiamare la funzione LoadScene(string) scrivendo il nome della scena che si vuole chiamare
    }

    public static void Quit()
    {
        Application.Quit();
        //come prima ma invece che chiamare LoadScene(String) si deve richiamare Quit()
    }
}
