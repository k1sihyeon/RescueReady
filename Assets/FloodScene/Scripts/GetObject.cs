using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour
{

    private Collider[] colls;
    private Collider hammer;
    [SerializeField] private float searchRange;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        searchRange = 5.0f;
        flag = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (flag)
        {
            colls = Physics.OverlapSphere(transform.position, searchRange);
            for (int i = 0; i < colls.Length; i++)
            {
                if (colls[i].name == "Hammer")
                {
                    //UI·Î Ç¥Çö ÇÊ¿ä
                    hammer = colls[i];
                    Debug.Log("E¸¦ ´­·¯ Å»Ãâ¿ë ¸ÁÄ¡¸¦ È¹µæÇÏ¼¼¿ä");
                    flag = false;
                }
            }
        }

        if(!flag)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hammer);
                Debug.Log("Å»Ãâ¿ë ¸ÁÄ¡ È¹µæ");
                //¸ÁÄ¡ µé°í ÀÖ´Â°Å Ã³·³ È­¸é
            }
        }
        

    }
}
