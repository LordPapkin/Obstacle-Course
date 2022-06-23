using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get { return health; }
    }   

    [SerializeField] private TextMeshProUGUI healthText;

    private void Awake()
    {
        UpdateHealth();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.collider.CompareTag("Hit"))            
            LoseHealth();
    }
    private void LoseHealth()
    {
        health--;
        UpdateHealth();
        Debug.Log("Hit Player");
    }
    private void UpdateHealth()
    {
        healthText.text = "Score: " + health.ToString();
    }    
}
