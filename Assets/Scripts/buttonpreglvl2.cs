using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonpreglvl2 : MonoBehaviour
{
    public GameObject puntcanva;

    public GameObject panelcanva;

    public GameObject audi;

    

    public GameObject soundctrl;

    public puntaje puntaje;

    public complist complist;
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
      audi.SetActive(true);
      audi.GetComponent<AudioSource>().PlayDelayed(3);


  }

  public void answer()
  {
      complist.videotic(0, 0.3f);
      puntaje.doublepoints();
      puntcanva.SetActive(true);
      SceneManager.LoadScene(2);
  }

  public void notright()
  {
      SceneManager.LoadScene(3);
      complist.videotic(1, 0.6f);
  }
}
