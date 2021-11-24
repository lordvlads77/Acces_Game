using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UInput : MonoBehaviour
{
    public RandSounds randSounds;
    public static int codeforcheck;
    public static int codechk2;

    public Succes succes;

    
    public AudioSource VictorySound;
    

    public int globalcheck;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            randSounds.sound1.GetComponent<AudioSource>().Play();
            codeforcheck = 1;
            Debug.Log(codeforcheck);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            randSounds.sound2.GetComponent<AudioSource>().Play();
            codechk2 = 2;
            Debug.Log(codechk2);
        }
        globalcheck = codeforcheck + codechk2;

        compare();

        
        

       
        
    }

   
    

    public void compare()
    {
        if (randSounds.globaldef == globalcheck)
        {
            randSounds.Clipicker(0, 0.3f);
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                SceneManager.LoadScene(1);
            }
            //Debug.Log("It just works!!!");

        }
    }
}
