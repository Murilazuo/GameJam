using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
    float time;
   
    [SerializeField]Animator anim;
    int idStage;
    [SerializeField]float timeToChange;

    bool start;

    GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
        idStage = 0;
        time = 0;     
        timeToChange = gameManager.level * 3f;
        start = false;
    }
    void Update()
    {
        if (!start)
        {
            time += Time.deltaTime;
            if(time >= 2)
            {
                start = true;
            }
        }else if(gameManager.level == 1)
        {
        switch (idStage)
        {
            case 0:
                time += Time.deltaTime;
                if(time >= timeToChange)
                {
                    
                    anim.SetTrigger("Fade");
                    idStage++;
                    time = 0;
                }
                break;
            case 1:
                time += Time.deltaTime;
                if(time >= timeToChange)
                {
                    gameManager.attackShadow = true;
                    time = 0;
                    idStage++;
                }
                break;
            case 2:
                time += Time.deltaTime;
                if (time >= timeToChange / 3)
                {
                    gameManager.attackShadow = false;
                    anim.SetTrigger("Fade1");
                    idStage++;
                }
                break;
            case 3:
                time += Time.deltaTime;
                if(time >= timeToChange * 2)
                {
                    time = 0;
                    idStage = 0;
                }
                break;
        }
        }

       
    }
}
