using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController charcontroller;
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 5f;
    private Vector3 moveDirection;

    // Singleton instance
    public static PlayerController instance;
    // Awake is called when the script instance is being loaded
    // Assuming you have some kind of player pieces variable
    public GameObject[] playerPieces; // Replace with actual type if different
    private void Awake()
    {
        // Ensure only one instance of the PlayerController exists
        if (instance == null)
        {
            instance = this;
            // Optionally, prevent this object from being destroyed between scenes
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Example of the Knockback method
    public void Knockback(Vector3 direction, float force)
    {
        // Implement knockback logic here
    }

    // Example of the Bounce method
    public void Bounce()
    {
        // Implement bounce logic here
    }

    // Example of the stopMove method
    public void stopMove()
    {
        // Implement stop move logic here
    }
    void Start()
    {
        // Código aquí
    }

    void Update()
    {
        float yStore = moveDirection.y;

        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;

     

        //Salto
        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;
        charcontroller.Move(moveDirection * Time.deltaTime);
    }
}