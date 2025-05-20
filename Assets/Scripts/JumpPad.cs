using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 20f; //점프 크기

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌발생");
        Rigidbody rb = collision.rigidbody;

        if (rb != null && collision.gameObject.CompareTag("Player"))//플레이어만 점프 가능하게 조건문 설정
        {
            // 수직 방향으로 점프하기
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z); // 기존 수직 속도 제거
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
