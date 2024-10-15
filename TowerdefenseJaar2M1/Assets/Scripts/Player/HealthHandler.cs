using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthHandler : MonoBehaviour
{
    
    private TMP_Text health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = GetComponent<TMP_Text>();  
        health.text = "health: " + EnemyMovement.lives;
    }
}
