using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarScore : MonoBehaviour
{
    public int Puntaje = 20;

    private void OnDestroy()
    {
        GameController.Score += Puntaje;
    }
}
