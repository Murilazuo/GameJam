using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    public int level;
    public bool hide;
    public bool attackShadow;
    public int shuriken;

    [SerializeField] GameObject pause;

    TileMovement tile;
    Player player;
    SoundController music;

    bool isPause;
    private void Start()
    {
        tile = FindObjectOfType(typeof(TileMovement)) as TileMovement;
        player = FindObjectOfType(typeof(Player)) as Player;
        music = FindObjectOfType(typeof(SoundController)) as SoundController;
        pause.SetActive(false);
        isPause = false;
        Cursor.visible = false;
        music.level = level;
    }
    private void Update()
    {
        if(attackShadow && !hide)
        {
            Respawn();
        }
        if (Input.GetButtonDown("Cancel"))
        {
            isPause = !isPause;
            if (isPause)
            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }
        
    }
    void Pause()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
        Cursor.visible = true;

    }
    void UnPause()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        pause.SetActive(false);

    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Respawn()
    {
        player.ResetPosition();
        tile.ResetPosition();
        
    }
    public  void Quit()
    {
        Application.Quit();
    }
    
}
