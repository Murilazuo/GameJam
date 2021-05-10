using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShurikenHUD : MonoBehaviour
{
    [SerializeField]GameObject[] shuriken;
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
    }
    void Update()
    {
        switch (gameManager.shuriken)
        {
            case 0:
                shuriken[0].SetActive(false);
                shuriken[1].SetActive(false);
                shuriken[2].SetActive(false);
                shuriken[3].SetActive(false);
                shuriken[4].SetActive(false);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 1:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(false);
                shuriken[2].SetActive(false);
                shuriken[3].SetActive(false);
                shuriken[4].SetActive(false);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 2:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(false);
                shuriken[3].SetActive(false);
                shuriken[4].SetActive(false);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 3:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(false);
                shuriken[4].SetActive(false);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 4:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(false);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 5:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(false);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 6:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(true);
                shuriken[6].SetActive(false);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 7:
                shuriken[1].SetActive(true);
                shuriken[0].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(true);
                shuriken[6].SetActive(true);
                shuriken[7].SetActive(false);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 8:
                shuriken[1].SetActive(true);
                shuriken[0].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(true);
                shuriken[6].SetActive(true);
                shuriken[7].SetActive(true);
                shuriken[8].SetActive(false);
                shuriken[9].SetActive(false);
                break;
            case 9:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(true);
                shuriken[6].SetActive(true);
                shuriken[7].SetActive(true);
                shuriken[8].SetActive(true);
                shuriken[9].SetActive(false);
                break;
            case 10:
                shuriken[0].SetActive(true);
                shuriken[1].SetActive(true);
                shuriken[2].SetActive(true);
                shuriken[3].SetActive(true);
                shuriken[4].SetActive(true);
                shuriken[5].SetActive(true);
                shuriken[6].SetActive(true);
                shuriken[7].SetActive(true);
                shuriken[8].SetActive(true);
                shuriken[9].SetActive(true);
                break;
        }
    }
  
}
