using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private bool moving = true;
    public List<GameObject> allpoints = new List<GameObject>();
    public List<GameObject> adjacent;
    public List<GameObject> deathPoints;
    public List<GameObject> cashPoints;
    public GameObject firstPoint;
    public GameObject currentTarget;
    public float speed = 4f;
    static int cash = 0;
    static int lives = 100;

    Vector3 differenceVector;
    Vector3 rotation;
    Vector3 Direction;
    Vector3 velocity;
    bool ticked;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float currentDistance = Vector3.Distance(currentTarget.transform.position, transform.position);
        Vector3 rotation = currentTarget.transform.position - transform.position;
        // float currentDeathstance = Vector3.Distance(go.transform.position);
       // Debug.Log(adjacent.Count);
        if (moving == true)
        {
            differenceVector = currentTarget.transform.position - transform.position;
            Direction = differenceVector.normalized;
            velocity = Direction * speed * Time.deltaTime;
            transform.position += velocity;
        }

        if (currentDistance < 0.1f)
        {
            transform.position = currentTarget.transform.position;
            moving = false;
            adjacent.Clear();
            checkLifeOrDeath();
        }
        if (adjacent.Count == 0)
        {
            checkAdjacent();
        }
        float newHeading = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, 180+newHeading);


    }
    void checkAdjacent()
    {
        foreach (GameObject point in allpoints)
        {
            if (point.transform.position.y + .6f > transform.position.y && point.transform.position.y - .6f < transform.position.y || point.transform.position.x + .6f > transform.position.x && point.transform.position.x - .6f < transform.position.x)
            {
                adjacent.Add(point);
                currentTarget = adjacent[Random.Range(0, adjacent.Count)];
                moving = true;
            }
        }
    }
    void checkLifeOrDeath()
    {
        if (transform.position.x > 8.5f)
        {
            lives -= 1;
            Destroy(gameObject);
        }
        if (transform.position.x < -8.5f)
        {
            cash += 1;
            Destroy(gameObject);
        }
    }

}

