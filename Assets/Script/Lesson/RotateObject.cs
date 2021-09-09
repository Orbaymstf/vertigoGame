using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson {
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSetting _rotateSettings;
        private void Update()
        {
            
            transform.Rotate(Vector3.up,_rotateSettings.Speed * Time.deltaTime);
            //100 frame per second 100*0.1=10
            //50 frame per second 50*0.2=10
        }
    }
}