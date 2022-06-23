using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] private float timer = 5f;

    private MeshRenderer meshRenderer;
    private Rigidbody rigid;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Time.time > timer)
        {
            meshRenderer.enabled = true;
            rigid.useGravity = true;            
        }
    }
}
