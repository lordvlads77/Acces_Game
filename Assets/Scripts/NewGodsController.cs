using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewGodsController : MonoBehaviour
{
    [SerializeField] public AudioClip[] clips;

    public AudioSource StateSounds;
     public GameObject bird1;
    public  GameObject bird2;

    public GameObject bird3;
    public static int setnum1;
    public static int setnum2;

    public static int setnum3;

    public int globalset;


    public List<int> BirdSoundsorter = new List<int> {1,2,3,};
    // Start is called before the first frame update
    void Start()
    {
        var shuffled = BirdSoundsorter.OrderBy(x => System.Guid.NewGuid()).ToList();
        for (int i =0; i<3; i++)
        {
            print(shuffled[i]);
        }
        
        if(shuffled[0] == 1)
        {
            bird1.GetComponent<AudioSource>().Play();
            setnum1 = 1;
        }
        if(shuffled[0] == 2)
        {
            bird2.GetComponent<AudioSource>().Play();
            setnum2 = 2;
            
        }
        if(shuffled[0] ==3)
        {
            bird3.GetComponent<AudioSource>().Play();
            setnum3 = 3;
        }
        
        if (shuffled[1] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(1);
            setnum1 = 1;
        }
        if (shuffled[1] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(1);
            setnum2 = 2;
        }
        if (shuffled[1] == 3)
        {
            bird3.GetComponent<AudioSource>().PlayDelayed(1);
            setnum3 = 3;
            
        }

        if (shuffled[2] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(2);
            setnum1 =1;
            
        }
        if (shuffled[2] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(2);
            setnum2 = 2;
            
        }
        if (shuffled[2] == 3)
        {
            bird3.GetComponent<AudioSource>().PlayDelayed(2);
            setnum3 = 3;
            
        }
        globalset = setnum1 + setnum2 + setnum3;

        BirdSoundsorter.Clear();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
