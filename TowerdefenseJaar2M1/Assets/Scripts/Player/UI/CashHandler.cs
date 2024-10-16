using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CashHandler : MonoBehaviour
{
    public static int cash;
    
    private TMP_Text moneycash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneycash = GetComponent<TMP_Text>();

        moneycash.text = "cash: " + EnemyMovement.cash;
    }
}
