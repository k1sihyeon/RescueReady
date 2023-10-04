using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.X) == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    //TODO: ���� ��ġ ���� �Ʒ��� �÷��̾�(ī�޶�) ��ġ �� ÷�� �Ҹ�
    //
}
