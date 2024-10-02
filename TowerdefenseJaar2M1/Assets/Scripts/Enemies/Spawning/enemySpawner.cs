using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    private float time = 0;
    [SerializeField] private List<GameObject> allpoints = new List<GameObject>();
    [SerializeField] private List<GameObject> adjacent = new List<GameObject>();
    [SerializeField] private List<GameObject> deathPoints = new List<GameObject>();
    [SerializeField] private List<GameObject> cashPoints = new List<GameObject>();
    [SerializeField] private GameObject firstTarget;
    [SerializeField] GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        GameObject currentEnemy = Instantiate(enemy);
        currentEnemy.GetComponent<EnemyMovement>().deathPoints = deathPoints;
        currentEnemy.GetComponent<EnemyMovement>().cashPoints = cashPoints;
        currentEnemy.GetComponent<EnemyMovement>().allpoints = allpoints;
        currentEnemy.GetComponent<EnemyMovement>().adjacent = adjacent;
        currentEnemy.GetComponent<EnemyMovement>().currentTarget = firstTarget;
        

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1) 
        {
            GameObject currentEnemy = Instantiate (enemy);
            currentEnemy.GetComponent<EnemyMovement>().deathPoints = deathPoints;
            currentEnemy.GetComponent<EnemyMovement>().cashPoints = cashPoints;
            currentEnemy.GetComponent<EnemyMovement>().allpoints = allpoints;
            currentEnemy.GetComponent<EnemyMovement>().adjacent = adjacent;
            currentEnemy.GetComponent<EnemyMovement>().currentTarget = firstTarget;
            time = 0;
        }
       
    }
}
