using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class controllerfirstlvl : MonoBehaviour
{
    [SerializeField] public AudioClip[] clips;
                                                                                                                
    public AudioSource StateSounds;
     public GameObject bird1;
    public  GameObject bird2;

                                                                                                                                                                                                                                                                                                                                                                         



    public succeslvl1 succeslvl1;
    public List<int> RandomList1 = new List<int>{1, 2}; // crear lista con numeros random
    public List<int> UserList1 = new List<int>(); // dependiendo de la eleccion del jugador
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
         for (int i = 0; i < 2; i++)
        {
            RandomList1.Add(Random.Range(1, 3));
        }
    }

    public void videotic(int indice, float volumen)
    {
        StateSounds.PlayOneShot(clips [indice], volumen);
    }

    public void soundpickeer()
    {
        if(RandomList1[0] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(3);
            //setnum1 = 1;
        }
        if(RandomList1[0] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(3);
            //setnum2 = 2;
            
        }
        
        
        if (RandomList1[1] == 1)
        {
            bird1.GetComponent<AudioSource>().PlayDelayed(1);
            //setnum1 = 1;
        }
        if (RandomList1[1] == 2)
        {
            bird2.GetComponent<AudioSource>().PlayDelayed(1);
            //setnum2 = 2;
        }
        
        
    }

    public void victi()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //crea una variable booleana, compara posicion vs la posicion de la otra lis
            bool isEqual = Enumerable.SequenceEqual(RandomList1.OrderBy(e => e), UserList1.OrderBy(e => e));

            if (isEqual)
            {
                succeslvl1.comparee();
                
            }
            else
            {

                SceneManager.LoadScene(0);
                
            }
            RandomList1.Clear();
            UserList1.Clear();
        }
        
    }
}
