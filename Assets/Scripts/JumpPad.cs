using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 20f; //���� ũ��

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹�߻�");
        Rigidbody rb = collision.rigidbody;

        if (rb != null && collision.gameObject.CompareTag("Player"))//�÷��̾ ���� �����ϰ� ���ǹ� ����
        {
            // ���� �������� �����ϱ�
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z); // ���� ���� �ӵ� ����
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
