using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    private Rigidbody playerRB; //Rigidbodx ���� �ν��Ͻ�
    public float force = 10.0f; //��
    void Start()
    {
        //���� ������Ʈ�� ������Ʈ �� Rigidbodx ������Ʈ�� ã�Ƽ� ��ȯ
        playerRB = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        { //���� ����Ű
            playerRB.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        { //������ ����Ű
            playerRB.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        { //���� ����Ű
            playerRB.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        { //�Ʒ��� ����Ű
            playerRB.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.Space) == true)
        { //�����̽�Ű
            playerRB.AddForce(Vector3.up * 1.0f,ForceMode.Impulse);
        }
    }
}