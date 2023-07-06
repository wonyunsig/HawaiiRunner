using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLeftRightController : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    public float distance = 5f; // 이동 거리

    private bool movingForward = true; // 현재 전진 중인지 여부
    private Vector3 initialPosition; // 초기 위치
    private float targetDistance; // 목표 이동 거리

    void Start()
    {
        initialPosition = transform.position; // 초기 위치 저장
        targetDistance = initialPosition.x + distance; // 목표 이동 거리 설정
    }

    void Update()
    {
        if (movingForward)
        {
            // 전진 방향으로 이동
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // 목표 이동 거리에 도달했는지 확인
            if (transform.position.x >= targetDistance)
            {
                movingForward = false; // 전진 중지, 후진 시작
            }
        }
        else
        {
            // 후진 방향으로 이동
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);

            // 초기 위치로 돌아왔는지 확인
            if (transform.position.x <= initialPosition.x)
            {
                movingForward = true; // 후진 중지, 다시 전진 시작
            }
        }
    }
}
