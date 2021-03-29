using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunDeafScene : MonoBehaviour
{
    public Image bg, notesBg, menuImg, rightChoiceBg;   
    public Text instructionTxt, pntTxt, typeTxt, messageTxt, delayTxt;
    public Button pointBtn, typeBtn, mochaBtn, cappacuinoBtn, machiatoBtn, latteBtn, americanoBtn, espressoBtn;
    public GameObject myPhone;

    int rightAnsClicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        bg.enabled = true;
        instructionTxt.enabled = true;
        pointBtn.enabled = true;
        pointBtn.GetComponent<Image>().enabled = true;
        typeBtn.enabled = true;
        typeBtn.GetComponent<Image>().enabled = true;
        pntTxt.enabled = true;
        typeTxt.enabled = true;
    }

    void Awake(){
        clearDeafMenu();
        
        //Type stuff
        notesBg.enabled = false;
        messageTxt.enabled = false;
        myPhone.GetComponent<MeshRenderer>().enabled = false;

        //Menu stuff
        menuImg.enabled = false;
        mochaBtn.enabled = false;
        mochaBtn.GetComponent<Button>().enabled = false;
        mochaBtn.GetComponent<Image>().enabled = false;
        cappacuinoBtn.enabled = false;
        cappacuinoBtn.GetComponent<Button>().enabled = false;
        cappacuinoBtn.GetComponent<Image>().enabled = false;
        machiatoBtn.enabled = false;
        machiatoBtn.GetComponent<Button>().enabled = false;
        machiatoBtn.GetComponent<Image>().enabled = false;
        latteBtn.enabled = false;
        latteBtn.GetComponent<Button>().enabled = false;
        latteBtn.GetComponent<Image>().enabled = false;
        americanoBtn.enabled = false;
        americanoBtn.GetComponent<Button>().enabled = false;
        americanoBtn.GetComponent<Image>().enabled = false;
        espressoBtn.enabled = false;
        espressoBtn.GetComponent<Button>().enabled = false;
        espressoBtn.GetComponent<Image>().enabled = false;

        rightChoiceBg.enabled = false;
        delayTxt.enabled = false;

        rightAnsClicked = 0;
        Debug.Log("Awake");

    }

    public void choseType(){
        clearDeafMenu();
        //TODO:
        // 1. Enable Text
        // 2. instantiate cube on counter
        // 3. Show you win
        myPhone.GetComponent<MeshRenderer>().enabled = true;
        notesBg.enabled = true;
        messageTxt.enabled = true;
        Debug.Log("start");
        //TODO: wait for seconds
        StartCoroutine(waitBeforeChangingScene(8, 4));
        Debug.Log("Last");
        //TODO: show win scene
        Debug.Log("You win");
    }

    public void chosePoint(){
        clearDeafMenu();
        menuImg.enabled = true;
        mochaBtn.enabled = true;
        mochaBtn.GetComponent<Button>().enabled = true;
        cappacuinoBtn.enabled = true;
        cappacuinoBtn.GetComponent<Button>().enabled = true;
        machiatoBtn.enabled = true;
        machiatoBtn.GetComponent<Button>().enabled = true;
        latteBtn.enabled = true;
        latteBtn.GetComponent<Button>().enabled = true;
        americanoBtn.enabled = true;
        americanoBtn.GetComponent<Button>().enabled = true;
        espressoBtn.enabled = true;
        espressoBtn.GetComponent<Button>().enabled = true;

    }

    public void youChosePoorly(){
        Debug.Log("You picked the wrong drink");
        //TODO: Show you chose poorly
        StartCoroutine(waitBeforeChangingScene(7, 5));
    }

    public void choseCorrect(){
    
        if(rightAnsClicked == 0){
            Debug.Log("Espresson");
            rightChoiceBg.enabled = true;
            delayTxt.enabled = true;
            delayTxt.GetComponent<Text>().text = "The barista thought you ordered Espresso.";
        }
        if(rightAnsClicked == 1){
            rightChoiceBg.enabled = true;
            delayTxt.enabled = true;
            delayTxt.GetComponent<Text>().text = "The barista thought you ordered Cappucino.";
            Debug.Log("Cappucino");
        }
        if(rightAnsClicked == 2){
            rightChoiceBg.enabled = true;
            delayTxt.enabled = true;
            delayTxt.GetComponent<Text>().text = "You got it";
            StartCoroutine(waitBeforeChangingScene(5, 4));
        }
        rightAnsClicked++;
    }

    public void clearDeafMenu(){
        //TODO: Clear canvas
        bg.enabled = false;
        instructionTxt.enabled = false;
        pntTxt.enabled = false;
        typeTxt.enabled = false;
        pointBtn.enabled = false;
        pointBtn.GetComponent<Image>().enabled = false;
        typeBtn.enabled = false;
        typeBtn.GetComponent<Image>().enabled = false;
    }

    IEnumerator waitBeforeChangingScene(int x, int scene)
    {
        //Print the time of when the function is first called.
        Debug.Log(x);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(x);
        SceneManager.LoadScene(scene);
    }

}
