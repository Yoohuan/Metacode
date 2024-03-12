using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PlayerControl : MonoBehaviour
{

    [Space(10)]
    [Header("玩家移动速度")]
    [SerializeField] float speed;
    // Start is called before the first frame update

    private Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float xMoveDir = Input.GetAxis("Horizontal");
        float yMoveDir = Input.GetAxis("Vertical");
        Vector2 playerVel = new Vector2(xMoveDir , yMoveDir );
        playerVel = playerVel * speed;
        myRigidbody.velocity = playerVel;
    }

    
}
