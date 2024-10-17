using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CashHandler : MonoBehaviour
{
   
    
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

        if (EnemyMovement.cash > 200)
        {
            SceneManager.LoadSceneAsync(6);
        }
    }
}
