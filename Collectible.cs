using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private Player _player;

    private void OnTriggerEnter(Collider other)
    {
        _player = other.GetComponent<Player>();
        _player.Score();

        Destroy(gameObject);
    }
}
