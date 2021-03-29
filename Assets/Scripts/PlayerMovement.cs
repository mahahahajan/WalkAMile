using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public bool isMoving = false;
    public AudioSource cane; 
    public GameObject myCam;
    public bool isBlindScene;
    public bool isDeafScene;

    public bool canPlayerMove;

    // Start is called before the first frame update
    void Start()
    {
        canPlayerMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        if(canPlayerMove){
            controller.Move(move*speed * Time.deltaTime);
        }
        
        if(isBlindScene){
            if (x != 0 || z != 0)
                isMoving = true;
            if (x == 0 && z == 0)
                isMoving = false;
            if (isMoving)
                if (cane.isPlaying == false)
                    cane.Play();
            if(!isMoving)
                cane.Stop();
            if(this.transform.position.x < 2 || this.transform.position.x > 7){
                //TODO: DIE
                SceneManager.LoadScene(5);
            } else{
                if(this.transform.position.z > 12.3){
                    Debug.Log("You win");
                    SceneManager.LoadScene(4);
                }
            }
        }

        if(isDeafScene){
            
            if(this.transform.position.z > -5.7){
                canPlayerMove = false;
                Vector3 playerPos = new Vector3(6.94862f, 0.6800001f, -5.663185f);
                this.transform.position = playerPos;
                myCam.transform.rotation = Quaternion.identity;
                myCam.GetComponent<MouseLook>().enabled = false;
                this.GetComponent<RunDeafScene>().enabled = true;
                this.GetComponent<PlayerMovement>().enabled = false;
            }
        }
        
    }

    static void OnCollisionEnter(Collision other) {
        // if(other.collider.gameObject.CompareTag("Finish")){
        //     Debug.Log("Yo");
        // }
        Debug.Log(other.collider.gameObject.name);
    }
}
