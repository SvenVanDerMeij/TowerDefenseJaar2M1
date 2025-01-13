using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public enum LevelDifficulty { Easy, Medium, Hard }
public class EnemySpawner : MonoBehaviour
{
    private float time = 0;
    private float attackSpeed = 1;
    [SerializeField] private List<GameObject> allpoints = new List<GameObject>();
    [SerializeField] private List<GameObject> adjacent = new List<GameObject>();
    [SerializeField] private List<GameObject> deathPoints = new List<GameObject>();
    [SerializeField] private List<GameObject> cashPoints = new List<GameObject>();
    [SerializeField] private GameObject firstTarget;
    [SerializeField] GameObject enemy;
     
    [SerializeField] private LevelDifficulty difficulty;
     
    private float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
        switch (difficulty)
        {
            case LevelDifficulty.Easy:
            multiplier = 0.8f;
            break;

            case LevelDifficulty.Medium:
            multiplier = 1f;
            break;

            case LevelDifficulty.Hard:
            multiplier = 1.2f;
            break;
        }
    spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        attackSpeed -= (Time.deltaTime)/100;
        if (time > attackSpeed) 
        {
            spawnEnemy();
            time = 0;
        }
       
    }
    public void spawnEnemy()
    {
        GameObject currentEnemy = Instantiate(enemy);
        currentEnemy.GetComponent<EnemyMovement>().deathPoints = deathPoints;
        currentEnemy.GetComponent<EnemyMovement>().cashPoints = cashPoints;
        currentEnemy.GetComponent<EnemyMovement>().allpoints = allpoints;
        currentEnemy.GetComponent<EnemyMovement>().adjacent = adjacent;
        currentEnemy.GetComponent<EnemyMovement>().currentTarget = firstTarget;
        currentEnemy.GetComponent<EnemyMovement>().multiplier = multiplier;
    }
}

