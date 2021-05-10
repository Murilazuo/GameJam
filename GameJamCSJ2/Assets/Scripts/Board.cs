using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    TileMovement tile;
    Player player;
    private void Start()
    {
        tile = FindObjectOfType(typeof(TileMovement)) as TileMovement;
        player = FindObjectOfType(typeof(Player)) as Player;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            tile.ResetPosition();
            player.ResetPosition();

    }
}
