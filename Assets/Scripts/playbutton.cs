using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
    public GameObject puntcanva;

    public GameObject panelcanva;

    public GameObject answeercorr;

    public GameObject soundctrl;

    public puntaje puntaje;

    public GameObject verdeee;

    public GameObject playbut;
    public GameObject  wrongans;
    public GameObject preg1;

    public controllerfirstlvl controllerfirstlvl;
    // Start is called before the first frame update
  public void canvapunt()
  {
      panelcanva.SetActive(false);
      puntcanva.SetActive(true);
      soundctrl.SetActive(true);
  }
  public void pregun()
  {
      panelcanva.SetActive(true);
      playbut.SetActive(false);
      answeercorr.SetActive(true);
      wrongans.SetActive(true);
      verdeee.SetActive(true);
      verdeee.GetComponent<AudioSource>().PlayDelayed(3);
      preg1.SetActive(true);



  }

  public void answer()
  {
      controllerfirstlvl.videotic(0, 0.3f);
      puntaje.doublepoints();
      puntcanva.SetActive(true);
      
      SceneManager.LoadScene(1);
  }

  public void notright()
  {
      controllerfirstlvl.videotic(1, 0.6f);
      SceneManager.LoadScene(1);
  }
}
