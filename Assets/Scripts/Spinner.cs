using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngel = 0;
    [SerializeField] float yAngel = 0;
    [SerializeField] float zAngel = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngel, yAngel, zAngel);
    }
}
