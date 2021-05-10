using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour
{
    [SerializeField]AudioClip[] music;
    public int level;
    public AudioClip[] sounds;
    // 0-Hit , 1-Jump, 2-Shuriken
    [SerializeField]AudioSource audioMusic;

    float time;
    bool canChange;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        canChange = true;
        audioMusic.clip = music[0];
    }
    private void Update()
    {
        if(time >= 10)
        {
            if (canChange)
            {
                canChange = false;
                audioMusic.clip = music[0];
                audioMusic.Play();
                SceneManager.LoadScene("Winter");
            }
        }
        else
        {
        time += Time.deltaTime;
        }
    }
    public void ChangeMusic(int id)
    {
        audioMusic.clip = music[id];
        audioMusic.Play();
    }
}
