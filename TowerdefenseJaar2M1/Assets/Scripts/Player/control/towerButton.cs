using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerButton : MonoBehaviour
{

    [SerializeField] GameObject hypnoTower;
    [SerializeField] GameObject barrier;
    [SerializeField] int button;

    static public bool mousefull = false;
    static public bool barrierPlaced = false;
    // Start is called before the first frame update

    public void TowerPick(int index)
    {
        switch (button)
        {
            case 0:
                if (EnemyMovement.cash > 50 && mousefull == false)
                {
                    GameObject Tower = Instantiate(hypnoTower);
                    Tower.GetComponent<PlaceTowers>().pickedUp = true;
                    mousefull = true;
                    EnemyMovement.cash -= 50;
                }
                break;
            case 1:
                if (mousefull == false && barrierPlaced == false)
                {
                    GameObject Barrier = Instantiate(barrier);
                    Barrier.GetComponent<PlaceTowers>().pickedUp = true;
                    mousefull = true;
                    barrierPlaced = true;
                }
                break;

        }
    }
}
