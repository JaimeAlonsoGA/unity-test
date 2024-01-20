using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class GoblinEnemyInteraction : MonoBehaviour
{
    public bool isGameOver = false;
    public void OnTriggerEnter(Collider other)
    {        
        if(other.gameObject.tag == "Enemy")
        {
            print("Game Over");
            isGameOver = true;
        }
    }
}