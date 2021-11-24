using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Succes : MonoBehaviour
{
    public UInput uInput;
    void Update()
    {
        Vic();
        
    }
    void Vic()
    {
    
        uInput.compare();

    }

    public void ChangeScene()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
