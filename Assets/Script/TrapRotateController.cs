using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRotateController : MonoBehaviour
{
    public float rotationSpeed = 10f; // 회전 속도

    void Update()
    {
        // 회전할 각도 계산
        float rotationAngle = rotationSpeed * Time.deltaTime;

        // 오브젝트를 회전시킴
        transform.eulerAngles += new Vector3(0f, 0f, rotationAngle *-1);
    }
}
