using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UInput1 : MonoBehaviour
{
    public controllerfirstlvl controllerfirstlvl;

    public succeslvl1 succeslvl1;
    
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
            controllerfirstlvl.bird1.GetComponent<AudioSource>().Play();
            controllerfirstlvl.UserList1.Add(1);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            controllerfirstlvl.bird2.GetComponent<AudioSource>().Play();
            controllerfirstlvl.UserList1.Add(2);        
      
        }
    }
        
}
