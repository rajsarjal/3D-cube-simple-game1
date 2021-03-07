using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContro : MonoBehaviour
{   Rigidbody rb;
   public GameObject winText;
    // Start is called before the first frame update
   public float speed;
   void Start()
   {
       speed = 10f;

      // Destroy(gameObject,5f);
       rb = GetComponent<Rigidbody>();


   }
    

        // update is called once per frame
         void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal")*Time.deltaTime*speed;
            float vertical = Input.GetAxisRaw("Vertical")*Time.deltaTime*speed;
            transform.Translate(horizontal,0f,vertical);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Destroy(gameObject,3f);

               // rb.AddForce(Vector3.up * 500);
            }
                
            //rb.velocity = Vector3.forward * 5f;
          if (Input.GetKeyDown(KeyCode.R))

        {
            SceneManager.LoadScene("level2");
        }
        
        }
        private void OnMouseDown()
        {
            Destroy(gameObject);
            
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Enemy")

            { 
               // Destroy(gameObject);
               Destroy(collision.gameObject);

               winText.SetActive(true);

            }
        }

    
    };



