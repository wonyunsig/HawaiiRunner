using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparentwall : MonoBehaviour
{
    public GameObject interactionPopup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wall"))
        {
            interactionPopup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("wall"))
        {
            interactionPopup.SetActive(false);
        }
    }
}
