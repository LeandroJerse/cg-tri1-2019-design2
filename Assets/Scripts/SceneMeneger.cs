using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SceneMeneger : MonoBehaviour
{
    public static SceneMeneger instance = null;

    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0);
    [SerializeField]
    private Transform Tape = null;

    public  UIComponents uiComponents;

    SceneData sceneData = new SceneData();

    void Awake() { 
    
        Assert.IsNotNull(Tape);
        if (instance == null){
            instance=this;
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();
    }
    public void IncrementCoinCount() {
        sceneData.coinCount = sceneData.coinCount + 1;
    }

    void DisplayHudData(){
        uiComponents.hud.txtCoinCount.text = "X "+ sceneData.coinCount;
    }
}
