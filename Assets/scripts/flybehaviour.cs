using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class flybehaviour : MonoBehaviour
{
    public int rotationspeed;
    public int velocity;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame|| Input.GetKeyDown("space")){
            rb.velocity=Vector2.up*velocity;
            


        }
        if(  Input.GetKeyDown("r")){
            pipeSpawner.instance.spawn=!pipeSpawner.instance.spawn;
            


        }
        
        
    }

    //this rotates the object
    private void FixedUpdate() {
        transform.rotation=Quaternion.Euler(0,0,rb.velocity.y*rotationspeed);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        
        GameManager.instance.gameOver();    
    }
}
