using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuacaoP1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bola"))
        {
            FindObjectOfType<GameManager>().addPontPlayer1();
        }
    }
}
