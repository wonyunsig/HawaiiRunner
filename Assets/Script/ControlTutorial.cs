using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTutorial : MonoBehaviour
{
    public GameObject Panel;
    private int count = 0;

    public void Tutorial()
    {
        Panel.SetActive(true);
        count = 1;
        Time.timeScale = 1;
    } 
    
    public void Confirm()
    {
        Panel.SetActive(false);
        count = 0;
        Time.timeScale = 1;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& count ==1)
        {
            Panel.SetActive(false);
            count = 0;
            Time.timeScale = 1;
        }
    }
}
