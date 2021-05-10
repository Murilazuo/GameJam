using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CutScene2 : MonoBehaviour
{
    [SerializeField] float cutSceneTime;
    [SerializeField] string scene;
    [SerializeField] bool destroySound;

    float time;
   

    GameObject soundController;
   
    void Update()
    {
        if(time >= cutSceneTime)
        {
            if(destroySound)
            {
            Destroy(soundController);
            }
            SceneManager.LoadScene(scene);
        }
        else
        {
        time += Time.deltaTime;
        }
    }
}
