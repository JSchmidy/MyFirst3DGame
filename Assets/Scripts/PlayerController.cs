using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rig;
    public float moveSpeed;
    public float jumpForce;

    private bool isGrounded;

    [SerializeField]
    private TMP_Text heartsText;
    [SerializeField]
    private FloatSO heartsSO;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float z = Input.GetAxisRaw("Vertical") * moveSpeed;
        
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        
        Vector3 vel = rig.velocity;
        vel.y = 0;
       
        if (vel.x != 0 || vel.z != 0)
        {
            transform.forward = vel;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            isGrounded = false;
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (transform.position.y < -5)
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            heartsSO.Hearts -= 1;
            heartsText.text = heartsSO.Hearts + ""; 
            
        }
        if (heartsSO.Hearts == 0)
        {
            GameOver();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.GetContact(0).normal == Vector3.up)
        {
            isGrounded = true;
        }
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene(4);
    }
}