using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   

    public int pontPlayer1;
    public int pontPlayer2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPontPlayer1()
    {
        pontPlayer1 += 1;
    }

    public void addPontPlayer2()
    {
        pontPlayer2 += 1;
    }

}
