using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LessonBasıc
{
    public class merhaba : MonoBehaviour
    {
        // Start is called before the first frame update
        public int sayı2 = 10;
        [SerializeField] int sayı = 1000;
        bool dogru = true;
        bool yanlıs2 = false;
        [SerializeField]private Vector3 ucFloat=new Vector3(1,2,3); //üç tane nokta
        //first lesson property
        //get ve set leri yönetmek
        public float floatProperty { get; private set; }
        void Start()
        {
            floatProperty = 100000000f;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}