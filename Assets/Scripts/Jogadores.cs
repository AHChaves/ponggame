using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{

    public float velocidade, yMax, yMin;
    public bool jogador1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jogador1 == true)
        {
            MovimentoDoPlayer1();
        }
        else
        {
            MovimentoDoPlayer2();
        }
    }

    public void MovimentoDoPlayer1()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }

    public void MovimentoDoPlayer2()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
        
    }

}
