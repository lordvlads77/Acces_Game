using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class presionaj : MonoBehaviour
{
    public controllerfirstlvl controllerfirstlvl;

    public puntaje puntaje;

    public GameObject canvapuut;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            controllerfirstlvl.videotic(0, 0.4f);
            puntaje.doublepoints();
            canvapuut.SetActive(true);

            SceneManager.LoadScene(1);


        }
    }
}
