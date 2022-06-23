using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Hit");
            GetComponent<MeshRenderer>().material.color = Color.red;
            Invoke("Hit", 0.05f);
        }      
       
    }
    private void Hit()
    {
        gameObject.tag = "Hit";
    }
}
