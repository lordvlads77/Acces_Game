using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class againquit : MonoBehaviour
{
    public GameObject quitag;

    public soundctrl soundctrl;
    // Start is called before the first frame update
    void Start()
    {
        quitag.GetComponent<AudioSource>().PlayDelayed(2);
    }

    // Update is called once per frame
    void Update()
    {
        again();
        quit();
    }

    public void again()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(0);
            soundctrl.stsound(0, 1f);
        }

    }
    public void quit()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();

        }
    }
}
