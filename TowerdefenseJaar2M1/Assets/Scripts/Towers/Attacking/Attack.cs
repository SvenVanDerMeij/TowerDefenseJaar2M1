using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform target;
    private float attacktimer = 0;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0)
        {
            return;
        }
        for (int i = 0; i < targets.Length; i++)
        {
            float dist = Vector2.Distance(transform.position, targets[i].transform.position);
            if (dist < 5)
            {
                 target = targets[i].transform;
               // LookAtTarget(target);
            }
        }

        attacktimer += Time.deltaTime;
        if (attacktimer > 1)
        {
            GameObject bullet = Instantiate(projectilePrefab);
            
            bullet.GetComponent<projectile>().target = target;
            bullet.GetComponent<Transform>().position = transform.position;
            attacktimer = 0;
            
        }

    }

   
   
}
