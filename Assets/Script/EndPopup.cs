using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPopup : MonoBehaviour
{
    public GameObject Endpopup;
    private PlayerMovement movement;
    private TicketManager ticket;

    private void Start()
    {
        movement = FindObjectOfType<PlayerMovement>();
        ticket = FindObjectOfType<TicketManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("End"))
        {
            if (ticket.TicketAmount == 4)
            {
                movement.canInteract = false;
                Endpopup.SetActive(true);
            }
        }
    }

}
