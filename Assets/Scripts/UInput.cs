using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UInput : MonoBehaviour
{
    public complist complist;

    public Succes succes;

    
    public AudioSource VictorySound;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            complist.bird1.GetComponent<AudioSource>().Play();
            complist.UserList.Add(1);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            complist.bird2.GetComponent<AudioSource>().Play();
            complist.UserList.Add(2);        
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            complist.bird3.GetComponent<AudioSource>().Play();
            complist.UserList.Add(3);
    
        }

        //compare();

        
        

       
        
    }

   
    

    
}
