using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds2 : MonoBehaviour
{
    public GameObject Sound2;
    int randSounds1;

    public GameObject sounds1;
    // Start is called before the first frame update
    void Start()
    {
        randSounds1 = Random.Range(0, 2);
        Debug.Log(randSounds1);
        if (randSounds1 == 0)
        {
            Sound2.GetComponent<AudioSource>().PlayDelayed(1);

        }
        if (randSounds1 == 1)
        {
            sounds1.GetComponent<AudioSource>().PlayDelayed(1);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
