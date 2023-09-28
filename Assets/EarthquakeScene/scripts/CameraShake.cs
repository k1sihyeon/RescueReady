using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraShake : MonoBehaviour
{
    //public Image attacked;

   // public GameObject player1;
   // public AudioSource AudioSource;
    //public AudioClip AudioClip;
    public Transform cameraTransform;
    private Vector3 originalPosition;
    private bool isShaking = false;
    public float duration = 1;
    public float intensity = 1;
    void Start()
    {
        if (cameraTransform == null)
        {
            cameraTransform = Camera.main.transform;
        }
       // AudioSource.clip = AudioClip;

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Shake();
        }
    }

    public void Shake()
    {

     
        
            if (!isShaking)
            {
                //AudioSource.Play();
                StartCoroutine(ShakeEffect(duration, intensity));
            }
        

    }

    private IEnumerator ShakeEffect(float duration, float intensity)
    {
        isShaking = true;
        originalPosition = cameraTransform.localPosition;
        float elapsed = 0f;


        while (elapsed < duration - 0.8)
        {
            float x = Random.Range(-0.1f, 0.1f) * intensity;
            float y = Random.Range(-0.1f, 0.1f) * intensity;

            cameraTransform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

            elapsed += Time.deltaTime;
            yield return null;
        }
        cameraTransform.localPosition = originalPosition;
        isShaking = false;

    }
}