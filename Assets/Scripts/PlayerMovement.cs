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
    // public GameObject camera;
    public bool isBlindScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move*speed * Time.deltaTime);

        if (x != 0 || z != 0)
            isMoving = true;

        if (x == 0 && z == 0)
            isMoving = false;

        if (isMoving)
            if (cane.isPlaying == false)
            cane.Play();
        if(!isMoving)
            cane.Stop();
        

        if(isBlindScene){
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

        

    }

    static void OnCollisionEnter(Collision other) {
        // if(other.collider.gameObject.CompareTag("Finish")){
        //     Debug.Log("Yo");
        // }
        Debug.Log(other.collider.gameObject.name);
    }
}
