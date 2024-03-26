using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{

    [Space(10)]
    [Header("玩家移动速度")]
    [SerializeField] float speed;
    // Start is called before the first frame update

    private Rigidbody2D myRigidbody;
    public Sprite PlayerLeft;
    public Sprite PlayerRight;
    private SpriteRenderer PlayerRenderer;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        PlayerRenderer = this.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float xMoveDir = Input.GetAxis("Horizontal");

        if (xMoveDir < 0)
        {
            PlayerRenderer.sprite = PlayerLeft;
        }
        if (xMoveDir > 0)
        {
            PlayerRenderer.sprite = PlayerRight;
        }

        float yMoveDir = Input.GetAxis("Vertical");
        Vector2 playerVel = new Vector2(xMoveDir , yMoveDir );
        playerVel = playerVel * speed;
        myRigidbody.velocity = playerVel;
    }

    
}
