using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject cane;
    public GameObject crosswalk1, crosswalk2, coffeeCup, register1, register2, register3;
    bool isBlindScene, isDeafScene;
    public Button blindButton, deafButton;
    public Button easyButton, hardButton, backButton;
    public Text difficultyText, easyText, hardText, backText;


    // Start is called before the first frame update
    void Start()
    {
        isDeafScene = false;
        isBlindScene = false;
        //Disable second menu
        clearMenu();

        //Enable main scene
        mainMenu();
    }

    public void mainMenu(){
        cane.GetComponent<MeshRenderer>().enabled = true;
        crosswalk1.GetComponent<MeshRenderer>().enabled = true;
        crosswalk2.GetComponent<MeshRenderer>().enabled = true;
        blindButton.GetComponent<Button>().enabled = true;

        coffeeCup.GetComponent<MeshRenderer>().enabled = true;
        register1.GetComponent<MeshRenderer>().enabled = true;
        register2.GetComponent<MeshRenderer>().enabled = true;
        register3.GetComponent<MeshRenderer>().enabled = true;
        // crosswalk2.GetComponent<MeshRenderer>().enabled = false;
        deafButton.GetComponent<Button>().enabled = true;
    }
    public void blindStart(){
        // Application.LoadLevel("Blind");
        isBlindScene = true;
        cane.GetComponent<MeshRenderer>().enabled = false;
        crosswalk1.GetComponent<MeshRenderer>().enabled = false;
        crosswalk2.GetComponent<MeshRenderer>().enabled = false;
        blindButton.GetComponent<Button>().enabled = false;

        coffeeCup.GetComponent<MeshRenderer>().enabled = false;
        register1.GetComponent<MeshRenderer>().enabled = false;
        register2.GetComponent<MeshRenderer>().enabled = false;
        register3.GetComponent<MeshRenderer>().enabled = false;
        // crosswalk2.GetComponent<MeshRenderer>().enabled = false;
        deafButton.GetComponent<Button>().enabled = false;
        showSecondMenu();
        Debug.Log("Hello world");
    }
    public void deafStart(){
        // Application.LoadLevel("Blind");
        isDeafScene = true;
        cane.GetComponent<MeshRenderer>().enabled = false;
        crosswalk1.GetComponent<MeshRenderer>().enabled = false;
        crosswalk2.GetComponent<MeshRenderer>().enabled = false;
        blindButton.GetComponent<Button>().enabled = false;

        coffeeCup.GetComponent<MeshRenderer>().enabled = false;
        register1.GetComponent<MeshRenderer>().enabled = false;
        register2.GetComponent<MeshRenderer>().enabled = false;
        register3.GetComponent<MeshRenderer>().enabled = false;
        // crosswalk2.GetComponent<MeshRenderer>().enabled = false;
        deafButton.GetComponent<Button>().enabled = false;

        showSecondMenu();
        Debug.Log("Hello world");
    }

    public void showSecondMenu(){
        easyButton.GetComponent<Image>().enabled = true;
        easyButton.GetComponent<Button>().enabled = true;
        easyText.GetComponent<Text>().enabled = true;
        hardButton.GetComponent<Image>().enabled = true;
        hardButton.GetComponent<Button>().enabled = true;
        hardText.GetComponent<Text>().enabled = true;
        backButton.GetComponent<Image>().enabled = true;
        backButton.GetComponent<Button>().enabled = true;
        backText.GetComponent<Text>().enabled = true;
        difficultyText.GetComponent<Text>().enabled = true;
    }
    public void clearMenu(){
        easyButton.GetComponent<Image>().enabled = false;
        easyButton.GetComponent<Button>().enabled = false;
        easyText.GetComponent<Text>().enabled = false;
        hardButton.GetComponent<Image>().enabled = false;
        hardButton.GetComponent<Button>().enabled = false;
        hardText.GetComponent<Text>().enabled = false;
        backButton.GetComponent<Image>().enabled = false;
        backButton.GetComponent<Button>().enabled = false;
        backText.GetComponent<Text>().enabled = false;
        difficultyText.GetComponent<Text>().enabled = false;
    }

    public void back(){
        isBlindScene = false;
        isDeafScene = false;
        clearMenu();
        mainMenu();
    }

    public void easy(){
        if(isBlindScene){
            // Application.LoadLevel();
            Debug.Log("Easy Blind Scene");
        }
        if(isDeafScene){
            Debug.Log("Easy def scene");
        }
    }

    public void hard(){
        if(isBlindScene){
            // Application.LoadLevel();
            Debug.Log("Hard Blind Scene");
        }
        if(isDeafScene){
            Debug.Log("Hard def scene");
        }
    }
}
