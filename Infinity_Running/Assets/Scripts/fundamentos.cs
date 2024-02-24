using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentos : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float velocidadeMovimento;

    public float limiteMaxY;
    public float limiteMinY;
    public float limiteMaxX;
    public float limiteMinX;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        float posY = transform.position.y;
        float posX = transform.position.x;

        playerRb.velocity = new Vector2(horizontal * velocidadeMovimento, vertical * velocidadeMovimento);

        //Verificar limite X
        if (transform.position.x < limiteMinX)
        {
            posX = limiteMinX;
        }
        else if (transform.position.x > limiteMaxX)
        {
            posX = limiteMaxX;
        }

        //Verificar limite Y
        if (transform.position.y > limiteMaxY)
        {
            posY = limiteMaxY;
        }
        else if (transform.position.y < limiteMinY)
        {
            posY = limiteMinY;
        }

        transform.position = new Vector3(posX, posY, 0);
    }
}
