using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundctrl : MonoBehaviour
{
    [SerializeField] public AudioClip[] clipers;
    public AudioSource soundStates;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stsound(int indice, float volumen)
    {
        soundStates.PlayOneShot(clipers [indice], volumen);
    }
}
