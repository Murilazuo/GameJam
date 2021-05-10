using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    public float baseSpeed;
    [SerializeField] float dashStart;
    float dashTime;
    readonly float dashCooldown = 5;
    [SerializeField]float dashTimerCooldown;

    GameManager gameManager;
    Rigidbody2D rig;

    public float speed;

    float v;
    [SerializeField]bool dash;
    public bool ground;

    public bool hit;

    Player player;
    [SerializeField] Vector3 gridStart;
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
        speed = baseSpeed;
        dashTime = dashStart;
        dash = true;
        player = FindObjectOfType(typeof(Player)) as Player;
    }   
    void Update()
    {
        v = Input.GetAxis("Vertical");

        Dash();


        

        
        if (gameManager.hide && v < 0 && ground)
        {
            speed = 0;
        } 
        else if (speed == 0)
        {
            speed = baseSpeed;
        }
    }
    void Dash()
    {
        if (gameManager.level > 1)
        {
                if (dashTime <= 0)
                {
                    dashTime = dashStart;
                    speed = baseSpeed;
                }
                else
                {
                    dashTime -= Time.deltaTime;
                if (Input.GetButtonDown("Horizontal"))
                {
                    player.AudioPlay(2);
                    player.anim.SetTrigger("Dash");
                    speed = baseSpeed * 4;
                    dash = false;
                }        
                }
        }
    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2(speed, 0);
    }
    public void ResetPosition()
    {
        transform.position = gridStart;
    }

}
