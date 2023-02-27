using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;


    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
