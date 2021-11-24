using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSounds : MonoBehaviour
{
    [SerializeField] public AudioClip[]  clipss;
    public AudioSource winlosesouds;
    public GameObject sound1;
    public GameObject sound2;
   

    public int randdsounds;
    public int randSound2;
    public static int predefnum;
    public static int predefnum1;

    public int globaldef;
    // Start is called before the first frame update
    public void Awake()
    {
        winlosesouds = GetComponent<AudioSource>();
    }
    void Start()
    {
        randdsounds = Random.Range(0, 2);
        randSound2 = Random.Range(0, 2);
        Soundsorter();
        SoundSorter2();

    }

    public void Clipicker(int indice, float volumen)
    {
        winlosesouds.PlayOneShot(clipss [indice], volumen);
    }

    void Soundsorter ()
    {
        if (randdsounds == 0)
        {
            sound1.GetComponent<AudioSource>().Play();
            predefnum = 1;
            Debug.Log(predefnum);
        }
        if (randdsounds == 1)
        {
            sound2.GetComponent<AudioSource>().Play();
            predefnum1 = 2;
            Debug.Log(predefnum1);
        }
      
    }

    void SoundSorter2()
    {
        if (randSound2 == 0)
        {
            sound1.GetComponent<AudioSource>().PlayDelayed(1);
            predefnum = 1;
        }
        if (randSound2 == 1)
        {
            sound2.GetComponent<AudioSource>().PlayDelayed(1);
            predefnum1 = 2;
        }
        globaldef = predefnum + predefnum1;
       
    }

    // Update is called once per frame
    void Update()
    {
    }
}
