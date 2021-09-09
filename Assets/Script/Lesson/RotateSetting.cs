using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson { 

    [CreateAssetMenu(menuName ="Lessons/Lesson1/RotateObject Setting")]
public class RotateSetting : ScriptableObject
{
        [SerializeField] private float _speed = 1;

        public float Speed { get { return _speed; } }
    }
}