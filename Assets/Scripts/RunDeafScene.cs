using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunDeafScene : MonoBehaviour
{
    public Image bg, notesBg;   
    public Text instructionTxt, pntTxt, typeTxt, messageTxt;
    public Button pointBtn, typeBtn;
    public GameObject myPhone;
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
        notesBg.enabled = false;
        messageTxt.enabled = false;
        myPhone.GetComponent<MeshRenderer>().enabled = false;
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
        StartCoroutine(waitBeforeShowingWinScene(8, 4));
        Debug.Log("Last");
        //TODO: show win scene
        Debug.Log("You win");
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

    IEnumerator waitBeforeShowingWinScene(int x, int scene)
    {
        //Print the time of when the function is first called.
        Debug.Log(x);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(x);
        SceneManager.LoadScene(scene);

        
    }

}
