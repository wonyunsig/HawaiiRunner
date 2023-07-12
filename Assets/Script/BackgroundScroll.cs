using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollAmount;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 moveDirction;

    private void Update()
    {
        transform.position += moveDirction * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -scrollAmount)
        {
            transform.position = target.position - moveDirction * scrollAmount;
        }
    }
}
