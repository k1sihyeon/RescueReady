using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarScriptsController : MonoBehaviour
    {


        public CarUserControl Car_control;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if(Car_control.carmode==0)
                {
                    Car_control.carmode = 1;
                }
                else
                {
                    Car_control.carmode = 0;
                }
               
            }
        }
    }
}