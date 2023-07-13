using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutDrop : MonoBehaviour
{
    public GameObject Coconut;
    public Transform FallPos;
    private int frame = 0;
    public int Spawnspeed = 777;

    void Update()
    {
        frame++;
        if (frame % Spawnspeed == 0)
        {
            Instantiate(Coconut).transform.position = FallPos.position;
        }
    }
}
