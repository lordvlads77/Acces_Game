using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class succeslvl1 : MonoBehaviour
{
    public controllerfirstlvl controllerfirstlvl;
    public UInput1 uInput1;
    public puntaje puntaje;

    public playbutton playbutton;
    

    public void comparee()
    {
        
       controllerfirstlvl.videotic(0, 0.5f);
       puntaje.pluspoints();
       playbutton.pregun();


       if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void lostt()
    {
        controllerfirstlvl.videotic(1, 0.5f);
        puntaje.lesspoints();
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            SceneManager.LoadScene(0);
        }
    }
}
