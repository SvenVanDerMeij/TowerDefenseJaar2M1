using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private bool moving = true;
    public List<GameObject> allpoints = new List<GameObject>();
    public GameObject[] adjacent;
    public GameObject firstPoint;
    public GameObject currentTarget;
    [SerializeField] float speed = 20f;

    Vector3 differenceVector;
    
    Vector3 Direction;
    Vector3 velocity;
    bool ticked;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = allpoints[Random.Range(0, allpoints.Count)];
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(adjacent);
        if (moving == true)
        {
            differenceVector = currentTarget.transform.position - transform.position;
            Direction = differenceVector.normalized;
            velocity = Direction * speed * Time.deltaTime;
            transform.position += velocity;
        }
        foreach (GameObject point in allpoints)
        {
            if (point.transform.position.y + .5f > transform.position.y && point.transform.position.y - .5f < transform.position.y && point.transform.position.x + .5f > transform.position.x && point.transform.position.x - .5f < transform.position.x)
            {
                moving = false;
                checkAdjacent();
                


            }
        }
        void checkAdjacent()
        {
            foreach (GameObject point in allpoints)
            {
                if (point.transform.position.y + .6f > transform.position.y && point.transform.position.y - .6f < transform.position.y || point.transform.position.x + .6f > transform.position.x && point.transform.position.x - .6f < transform.position.x)
                {


                    


                }
            }
        }

        
    }
}
