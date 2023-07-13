using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TicketManager : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public int TicketAmount;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ticket"))
        {
            TicketAmount += 1;
        }
    }

    private void Update()
    {
        Score.text = TicketAmount + "/4";
    }
}
