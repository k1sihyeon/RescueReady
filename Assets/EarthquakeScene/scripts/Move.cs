using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    private Rigidbody playerRB; //Rigidbodx 저장 인스턴스
    public float force = 10.0f; //힘
    void Start()
    {
        //현재 오브젝트의 컴포넌트 중 Rigidbodx 컴포넌트를 찾아서 반환
        playerRB = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        { //왼쪽 방향키
            playerRB.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        { //오른쪽 방향키
            playerRB.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        { //위쪽 방향키
            playerRB.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        { //아래쪽 방향키
            playerRB.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.Space) == true)
        { //스페이스키
            playerRB.AddForce(Vector3.up * 1.0f,ForceMode.Impulse);
        }
    }
}