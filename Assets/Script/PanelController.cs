using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject Panel;
    private int count = 0;

    public void OptionButton()
    {
        Panel.SetActive(true);
        count = 1;
        Time.timeScale = 0;
    }

    public void ResumeButton()
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
        else if (Input.GetKeyDown(KeyCode.Escape)&& count == 0)
        {
            Panel.SetActive(true);
            count = 1;
            Time.timeScale = 0;
        }

    }
}
