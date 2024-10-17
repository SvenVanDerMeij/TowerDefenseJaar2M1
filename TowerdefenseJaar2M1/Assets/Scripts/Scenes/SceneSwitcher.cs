using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] public int sceneID;
    public void LoadScene()
    {
        EnemyMovement.lives = 50;
        EnemyMovement.cash = 75;
        towerButton.barrierPlaced = false;
         SceneManager.LoadSceneAsync(sceneID);                      
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}