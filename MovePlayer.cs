using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float RunSpeed = 4f;
    public float runSpeed = 2f;
    public float jumpSpeed = 3;
    public float doubleJumpSpeed = 2.5f;
    private bool canDoubleJump;
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d") || Input.GetKey("right")){
            rb2D.linearVelocity = new Vector2(runSpeed, rb2D.linearVelocityY);
            GetComponent<SpriteRenderer>().flipX= false;
        } else if (Input.GetKey("a") || Input.GetKey("left")){ 
            rb2D.linearVelocity = new Vector2(-runSpeed, rb2D.linearVelocityY);
            GetComponent<SpriteRenderer>().flipX= true;
        } else {
            rb2D.linearVelocity= new Vector2(0, rb2D.linearVelocityY);
        }
        if(Input.GetKey("space") || Input.GetKey("up") || Input.GetKey("w")){
            if(Chekeo.isGrounded){
                canDoubleJump = true;
                rb2D.linearVelocity = new Vector2(rb2D.linearVelocityX, jumpSpeed);
            } else {
                if ((Input.GetKeyDown("space") || Input.GetKeyDown("up") || Input.GetKeyDown("w")) && canDoubleJump) {
                    rb2D.linearVelocity = new Vector2(rb2D.linearVelocityX, doubleJumpSpeed);
                    canDoubleJump = false;
                }
            }
    
        }
        if (Input.GetKey(KeyCode.LeftShift)){
            runSpeed = RunSpeed;//corre mas rapido
        } else {
            runSpeed = 2;//vuelve a correr a la misma velocidad
        }
    }

}
