using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorldHandler : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI helloWorld;
    private List<(int, char)> key = new List<(int, char)>();
    private static char[] hw = new char[11];
    private static bool[] completion = new bool[7];
    private static bool isComplete = false;
    
    // original[3] = d
    // original[4] = e
    // original[7] = h
    // original[11] = l
    // original[14] = o
    // original[17] = r
    // original[22] = w
    
    // Start is called before the first frame update
    
    void Start() {
        //GetKey();
        SetBlanks();
    }
    

    // Update is called once per frame
    void Update()
    {
        DisplayHelloWorld();
        CheckHelloWorld();
    }
    

    public static void SetBlanks() {
        for (int i = 0; i < hw.Length; i++) {
            hw[i] = '#';
            
            if (i == 5) {
                hw[i] = ' ';
            }
        }

        for (int i = 0; i < completion.Length; i++) {
            completion[i] = false;
        }
    }
    
    public void GetKey() {
        key.Add((3, 'd'));
        key.Add((4, 'e'));
        key.Add((7, 'h'));
        key.Add((11, 'l'));
        key.Add((14, 'o'));
        key.Add((17, 'r'));
        key.Add((22, 'w'));
    }

    public static void CheckHelloWorld() {
        for (int i = 0; i < completion.Length; i++) {
            if (completion[i]) {
                isComplete = true;
            }
            else {
                isComplete = false;
            }
        }

        if (isComplete)
        {
            SceneLoader.NextScene();
        }
    }

    public void DisplayHelloWorld() {
        helloWorld.text = "";
        foreach (var ch in hw) {
            helloWorld.text += ch;
        }
    }

    public static void GetDeletedOffset(char ch) {
        if (ch == 'h') {
            hw[0] = 'h';
            completion[0] = true;
        }
        else if (ch == 'e') {
            hw[1] = 'e';
            completion[1] = true;
        }
        else if (ch == 'l') {
            hw[2] = 'l';
            hw[3] = 'l';
            hw[9] = 'l';
            completion[2] = true;
        }
        else if (ch == 'o') {
            hw[4] = 'o';
            hw[7] = 'o';
            completion[3] = true;
        }
        else if (ch == 'w') {
            hw[6] = 'w';
            completion[4] = true;
        }
        else if (ch == 'r') {
            hw[8] = 'r';
            completion[5] = true;
        }
        else if (ch == 'd') {
            hw[10] = 'd';
            completion[6] = true;
        }
    }

}
