using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //andare sull' OnClick() del pulsante e collegare Canvas in basso a sinistra, poi trovare SceneManagerScript e aggiungere il LoadScene(script)
        //al che aggiungere il nome della scena dopo averla aggiunta al Project Editor
    }

    public void Quit()
    {
        Application.Quit();
        //come su ma invece di LoadScene(Script) si deve cliccare su Quit()
    }

}
