using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Transform target;
    [SerializeField] private float speed = 10;


    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }


        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < 0.1) 
        {
            Destroy(gameObject);
        }
    }
}
