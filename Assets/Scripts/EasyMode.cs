using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EasyMode : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] private TextMeshProUGUI available, unavailable;

    // Needed elements
    private char[] original = new char[26], offset = new char[26]; //, unusable = new char[26];
    private static List<char> availableChars = new List<char>(), unavailableChars = new List<char>();
    private bool isLegit; 
    

    // Start is called before the first frame update
    void Start() {
        GenerateOffset();
        InputHandler.GetOffset(offset);
        InputHandler.GenerateInputList();
        availableChars = InputHandler.GenerateCharList();
        //Debug.Log("Cipher = " + new string(offset));

    }

    // Update is called once per frame
    void Update() {
        InputHandler.Inputs();
        unavailableChars = InputHandler.GetUnavailableCharList();
        
        DisplayOptions();
    }

    public void DisplayOptions() {
        DisplayAvailableOptions(); 
        DisplayUnavailableOptions();
    }
    
    public void DisplayAvailableOptions() {
        available.text = "";
        foreach (char ch in availableChars) {
            available.text += (ch + "  ");
        }
    }

    public void DisplayUnavailableOptions() {
        unavailable.text = "";
        foreach (var ch in unavailableChars) {
            unavailable.text += (ch + "  ");
        }
    }

    public void GenerateOffset() {
        original = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
        //int shift = (int) Random.Range(1, 26);
        int shift = 1;
        Debug.Log("Shift Amount = " + shift);

        for (int i = 0; i < 26; i++) {
            offset[i] = original[shift];
            //Debug.Log(offset[i]);
            shift++;

            if (shift >= 26) {
                shift = 0;
            }
        }
    }

    public static void Reset() {
        availableChars.Clear();
        unavailableChars.Clear();
    }
}
    

