using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconutDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
