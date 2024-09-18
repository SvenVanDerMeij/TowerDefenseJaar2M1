using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField]  private List<GameObject> allpoints = new List<GameObject>();
    [SerializeField] GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        GameObject currentEnemy =Instantiate(enemy);
        currentEnemy.GetComponent<EnemyMovement>().allpoints = allpoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
