using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private bool moving = true;
    public List<GameObject> allpoints = new List<GameObject>();
    public List<GameObject> adjacent;
    public GameObject firstPoint;
    public GameObject currentTarget;
    public float speed = 4f;

    Vector3 differenceVector;
    
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
       Debug.Log(adjacent.Count);
        if (moving == true)
        {
            differenceVector = currentTarget.transform.position - transform.position;
            Direction = differenceVector.normalized;
            velocity = Direction * speed * Time.deltaTime;
            transform.position += velocity;
        }
        
            if (currentDistance < 0.2f)
            {
                moving = false;       
                adjacent.Clear();
            }
            if (adjacent.Count == 0) 
             {
               checkAdjacent();
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
        }
    }

