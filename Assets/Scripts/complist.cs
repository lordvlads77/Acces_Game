using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
public class complist : MonoBehaviour
{
    [SerializeField] public AudioClip[] clips;
                                                                                                                
    public AudioSource StateSounds;
     public GameObject bird1;
    public  GameObject bird2;                                                                                                                                                                                                                                                                                                                                                                              

    public GameObject bird3;

    public Succes succes;
    public List<int> RandomList = new List<int>{1, 2 , 3}; // crear lista con numeros random
    public List<int> UserList = new List<int>(); // dependiendo de la eleccion del jugador
    // Start is called before the first frame update
    void Start()
    {
            
       
        fill();
        soundpickeer();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        victi();

    }

    public void fill()
    {
         for (int i = 0; i < 3; i++)
        {
            RandomList.Add(Random.Range(1, 4));
        }
    }

    public void videotic(int indice, float volumen)
    {
        StateSounds.PlayOneShot(clips [indice], volumen);
    }

    public void soundpickeer()
    {
        if(RandomList[0] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(10);
            //setnum1 = 1;
        }
        if(RandomList[0] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(10);
            //setnum2 = 2;
            
        }
        if(RandomList[0] ==3)
        {
            bird3.GetComponent<AudioSource>().PlayDelayed(10);
            //setnum3 = 3;
        }
        
        if (RandomList[1] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(11);
            //setnum1 = 1;
        }
        if (RandomList[1] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(11);
            //setnum2 = 2;
        }
        if (RandomList[1] == 3)
        {
            bird3.GetComponent<AudioSource>().PlayDelayed(11);
            //setnum3 = 3;
            
        }

        if (RandomList[2] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(12);
            //setnum1 =1;
            
        }
        if (RandomList[2] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(12);
            //setnum2 = 2;
            
        }
        if (RandomList[2] == 3)
        {
            bird3.GetComponent<AudioSource>().PlayDelayed(12);
            //setnum3 = 3;
            
        }
    }

    public void victi()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //crea una variable booleana, compara posicion vs la posicion de la otra lis
            bool isEqual = Enumerable.SequenceEqual(RandomList.OrderBy(e => e), UserList.OrderBy(e => e));

            if (isEqual)
            {
                succes.compare();
            }
            else
            {
                SceneManager.LoadScene(1);
            }
            RandomList.Clear();
            UserList.Clear();
        }
        
    }

}
