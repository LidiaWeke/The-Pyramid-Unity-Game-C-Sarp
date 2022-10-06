using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposicionamiento : MonoBehaviour
{
   [SerializeField] //nos ayuda a reconocer los objetos que tenemos creados en Unity
   private Transform player;
   [SerializeField] 
   private Transform respawnPoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            collision.transform.position = respawnPoint.position;
    }


}
