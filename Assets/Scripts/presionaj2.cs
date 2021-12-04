using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class presionaj2 : MonoBehaviour
{
    public complist complist;

    public GameObject pannn;

    public puntaje puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            complist.videotic(0, 0.5f);
            puntaje.doublepoints();
            pannn.SetActive(false);
            SceneManager.LoadScene(2);
            
        }
    }
}
