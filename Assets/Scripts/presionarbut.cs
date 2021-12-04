using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presionarbut : MonoBehaviour
{
    public controllerfirstlvl controllerfirstlvl;
    public GameObject pbutton;
    public GameObject panell;
    public GameObject scori;

    public GameObject soundi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            pbutton.SetActive(false);
            panell.SetActive(false);
            scori.SetActive(true);
            soundi.SetActive(true);
            controllerfirstlvl.videotic(2, 1f);
        }
    }
}
