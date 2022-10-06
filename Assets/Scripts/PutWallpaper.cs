using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutWallpaper : MonoBehaviour
{
    public float velocidad;
    private MeshRenderer wallpaper;
    // Start is called before the first frame update
    void Start()
    {
        wallpaper = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        wallpaper.material.mainTextureOffset = new Vector3(Time.time * velocidad * 1f, 0, 0);
    }
}
