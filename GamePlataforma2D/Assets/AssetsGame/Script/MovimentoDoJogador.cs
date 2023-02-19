using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    [Header("Referencias")]
    private Rigidbody2D oRigidbody2D;

    [Header("MovimentoHorizontal")]
    public  float VelocidadeDoJodador;
    public bool IndoParaDireita;
    
    [Header("AnimadorDoPersonagem")]
    private Animator oAnimator;


    void Awake()
    {
       oRigidbody2D = GetComponent<Rigidbody2D>(); 
       oAnimator = GetComponent<Animator>();      

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

        if(movimentoHorizontal > 0)
        {
          transform.localScale = new Vector3(1f, 1f, 1f);
          IndoParaDireita = true;

        }
        else if(movimentoHorizontal < 0)
        {
           transform.localScale = new Vector3(-1f, 1f, 1f);
           IndoParaDireita = false;


        }

        if(movimentoHorizontal == 0)
        {
          oAnimator.Play("jogador-idle");

        }
        else if(movimentoHorizontal != 0)
        {
          oAnimator.Play("jogador-andando");

        }

    } 


}
