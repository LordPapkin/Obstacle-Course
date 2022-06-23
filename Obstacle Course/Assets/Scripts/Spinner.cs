using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float yAngle = 1f;
    [SerializeField] private float rotatingSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yAngle*rotatingSpeed*Time.deltaTime, 0);
    }
}
