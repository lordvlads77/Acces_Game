using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
    public float points;
    public Text scorescreen;


    // Start is called before the first frame update
    public void pluspoints()
    {
        points++;
        scorescreen.text = points.ToString();
    }

    public void lesspoints()
    {
        points--;
        scorescreen.text = points.ToString();
    }

    public void doublepoints()
    {
        points++;
        points++;
    }
}
