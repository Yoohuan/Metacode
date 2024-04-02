using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{

    [Space(10)]
    [Header("����ƶ��ٶ�")]
    [SerializeField] float speed;
    // Start is called before the first frame update

    private Rigidbody2D myRigidbody;
    public Sprite PlayerLeft;
    public Sprite PlayerRight;
    private SpriteRenderer PlayerRenderer;
    public bool inPanel;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        PlayerRenderer = this.GetComponent<SpriteRenderer>();

        inPanel = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!inPanel)
        {
            Move();
        }
        else
        {
            Vector2 playerStop = new Vector2 (0, 0);
            myRigidbody.velocity = playerStop;
        }
        
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
