using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public float velocidadeDaBola;
    public Rigidbody2D colisao;

    // Start is called before the first frame update
    void Start()
    {
        colisao.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola ) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
