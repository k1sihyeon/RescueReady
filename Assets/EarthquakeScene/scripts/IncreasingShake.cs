using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingShake : MonoBehaviour
{
    
    public GameObject ground;
    public CameraShake Camera_Shake;
    private CameraShake CameraShake_Scrpit;

    
    private void OnTriggerEnter(Collider other)
    {
        
        Camera_Shake.intensity = 7;
        Camera_Shake.duration = Camera_Shake.duration + 5;
        CameraShake_Scrpit.Shake();
        Debug.Log("∂•ø° ¥Í¿Ω");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        CameraShake_Scrpit = FindObjectOfType<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
