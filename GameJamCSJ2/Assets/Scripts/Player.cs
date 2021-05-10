using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    TileMovement tileMove;
    GameManager gameManager;
    Rigidbody2D rig;
    [SerializeField]GameObject shuriken;
    Timer timer;

    [SerializeField]LayerMask hide, ground;
    [SerializeField] float jumpForce;
    [SerializeField] float highGroundCheck;

    public Animator anim;
    SoundController sound;
    AudioSource audio;

    [SerializeField] Vector3 playerStart;
  
    bool isGround;
    void Start()
    {
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
        tileMove = FindObjectOfType(typeof(TileMovement)) as TileMovement;
        timer = FindObjectOfType(typeof(Timer)) as Timer;
        sound = FindObjectOfType(typeof(SoundController)) as SoundController;
        rig = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        tileMove.ground = isGround;
        if(isGround && Input.GetButtonDown("Jump"))
        {
            audio.clip = sound.sounds[1];
            audio.Play();
            rig.AddForce(new Vector2(0, 10 * jumpForce));
        }
        if(gameManager.level > 2 && Input.GetButtonDown("Fire2") && gameManager.shuriken > 0)
        {
            audio.clip = sound.sounds[2];
            audio.Play();
            Instantiate(shuriken, transform.position, Quaternion.identity);
            gameManager.shuriken--;
        }
       
        
        
    }
    private void FixedUpdate()
    {
        if(rig.velocity.y >= 20)
        {
            rig.velocity = new Vector2(0, 20);
        }
        if (rig.velocity.y <= -20)
        {
            rig.velocity = new Vector2(0, -20);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Hiden":
                gameManager.hide = true;
                break;
          
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Hiden":
                gameManager.hide = false;
                break;
            case "Collect":
                gameManager.shuriken++;
                Destroy(collision.gameObject);
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "Ground":
                rig.velocity = new Vector2(0, 0);
                isGround = true;

                break;
            case "Win":
                switch (gameManager.level)
                {
                    case 1:
                        gameManager.ChangeScene("CutSceneSpring");
                        break;
                    case 2:
                        gameManager.ChangeScene("CutSceneSummer");
                        break;
                    case 3:
                        gameManager.ChangeScene("CutSceneAutumn");
                        break;
                    case 4:
                        gameManager.ChangeScene("CutSceneFinal");
                        break;
                }
                break;
            case "Enemy":
                tileMove.hit = true;
                gameManager.Respawn();
                break;

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "Ground":
                isGround = false;
                anim.SetBool("Ground", false);

                break;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "GroundBoard":
                isGround = false;
                anim.SetBool("Ground", true);
                break;
            case "Ground":
                anim.SetBool("Ground", true);
                break;
        }
    }
    public void ResetPosition()
    {
        transform.position = playerStart;        
    }
    public void AudioPlay(int id)
    {
        audio.clip = sound.sounds[id];
        audio.Play();
    }
}
