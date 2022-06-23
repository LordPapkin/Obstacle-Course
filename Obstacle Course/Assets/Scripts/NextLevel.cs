using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private Scorer scorer;
    private int playerHealth;

    private int sceneIndex;

    private bool win = false;

    [SerializeField] private ParticleSystem winParticle;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (!other.CompareTag("Player")) 
        {
            return;
        }
        if (win)
        {
            return;
        }           
        scorer = other.gameObject.GetComponent<Scorer>();
        win = true;
        CheckWin();
    }
    private void CheckWin()
    {
        playerHealth = scorer.Health;
        if (playerHealth > 0)
        {
            winParticle.Play();
            Invoke("LoadNextLevel", 2f);
        }
        else
        {
            Invoke("ResetLevel", 2f);
        }
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    private void ResetLevel()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
   
}
