using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
 
    void Update()
    {
        transform.localRotation = Quaternion.Euler(10f, Time.time * 40f, 0);
    }
}
