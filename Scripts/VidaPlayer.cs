using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    [SerializeField] Transform RespawnPoint;

    public GameObject[] hearts;
    public int vidas;
    public Transform Target;
    public GameObject Player;

    public GameObject MenuMuerte;

    void Start()
    {
        MenuMuerte.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (vidas < 1)
        {
            hearts[0].gameObject.SetActive(false);
        }
        if (vidas < 2)
        {
            hearts[1].gameObject.SetActive(false);
        }
        if (vidas < 3)
        {
            hearts[2].gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    //Al caer reaparece y quita una vida
    {
        if (col.gameObject.tag == "Respawn")
        {
            vidas--;
        }

        if (vidas < 0)
        {
            MenuMuerte.gameObject.SetActive(true);
        }
        
    }
    
}
