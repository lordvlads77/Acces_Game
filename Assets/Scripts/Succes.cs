using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Succes : MonoBehaviour
{
    public complist complist;
    public UInput uInput;

    public puntaje puntaje;

    public buttonpreglvl2 buttonpreglvl2;
    

  public void compare()
    {
        
       complist.videotic(0, 0.5f);
       puntaje.pluspoints();
       buttonpreglvl2.pregun();


       if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void lost()
    {
        complist.videotic(1, 0.5f);
        puntaje.lesspoints();
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            SceneManager.LoadScene(1);
        }
    }
}
