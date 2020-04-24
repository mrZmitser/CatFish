using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveScript : MonoBehaviour {
    public float speed;
    private bool isFacingRight = true;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        anim.SetFloat("SpeedX", Mathf.Abs(moveInput.x));
        anim.SetFloat("SpeedY", moveInput.y);
        if (moveInput.x > 0 && !isFacingRight || moveInput.x < 0 && isFacingRight){
            Flip();
        }
        moveVelocity = moveInput.normalized * speed;
    }
    private void Flip() {
        isFacingRight = !isFacingRight;
        rb.transform.localScale = new Vector3 ((-1)*rb.transform.localScale.x, rb.transform.localScale.y, rb.transform.localScale.z);
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
       
    }
   
}
