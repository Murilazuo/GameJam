using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] float attackCouldown;
    [SerializeField] Animator anim;
    float nextAttack;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType(typeof(Player)) as Player;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextAttack)
        {
            player.AudioPlay(0);
            anim.SetTrigger("Attack");
            nextAttack = Time.time + attackCouldown;
        }
    }
}
