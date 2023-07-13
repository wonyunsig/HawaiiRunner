using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutDrop : MonoBehaviour
{
    public GameObject Coconut;
    public Transform FallPos;
    private int frame = 0;

    void Update()
    {
        frame++;
        if (frame % 777 == 0)
        {
            Instantiate(Coconut).transform.position = FallPos.position;
        }
    }
}
