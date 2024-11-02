using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.CompareTag("Lava"))
        {
            gameOverScreen.SetActive(true);
        }
        else if(collision.gameObject.CompareTag("Enemy"))
        {
            gameOverScreen.SetActive(true);
        }
    }
}
