using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perder1 : MonoBehaviour
{
   public void yadead()
   {
       if (Input.GetKeyDown(KeyCode.Keypad5))
       {
           SceneManager.LoadScene(0);
           Debug.Log("worked");
       }
   }
}
