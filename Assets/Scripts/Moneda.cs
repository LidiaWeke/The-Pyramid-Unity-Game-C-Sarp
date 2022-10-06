using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public GameObject EffectDie;

    public AudioClip sonidoMoneda;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(sonidoMoneda, transform.position);
        }
        Destroy(gameObject);
    }
}
