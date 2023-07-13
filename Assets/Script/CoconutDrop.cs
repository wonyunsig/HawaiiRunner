using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutDrop : MonoBehaviour
{
    public GameObject Coconut;
    public Transform FallPos;
    public float originaltime = 1f;
    public float Spawnspeed;

    void Update()
    {
        Spawnspeed -= Time.deltaTime;
        
        if (Spawnspeed<=0)
        {
            Instantiate(Coconut).transform.position = FallPos.position;
            Spawnspeed = originaltime;
        }
    }
}
