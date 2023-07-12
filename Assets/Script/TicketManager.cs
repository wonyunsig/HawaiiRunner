using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketManager : MonoBehaviour
{
    public GameObject ticket;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(ticket);
    }
}
