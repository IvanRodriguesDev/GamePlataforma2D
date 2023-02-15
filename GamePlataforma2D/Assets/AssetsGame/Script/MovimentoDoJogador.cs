using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    private Rigidbody2D oRigidbody2D;
    public  float VelocidadeDoJodador;
    

    void Awake()
    {
       oRigidbody2D = GetComponent<Rigidbody2D>();       

    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       MovimentarJogador();        

    }

    private void MovimentarJogador()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        oRigidbody2D.velocity = new Vector2(movimentoHorizontal *VelocidadeDoJodador, oRigidbody2D.velocity.y);

    } 


}