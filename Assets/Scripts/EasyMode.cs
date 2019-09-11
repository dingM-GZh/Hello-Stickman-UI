using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EasyMode : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] private TextMeshProUGUI available, selections;

    // Needed elements
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private char[] original = new char[26], offset = new char[26], unusable = new char[26];

    // Start is called before the first frame update
    void Start() {
        original = (alphabet.ToLower()).ToCharArray();
        available.text = "";
        
        foreach (char ch in original) {
            available.text += (ch + "  ");
        }
        GenerateOffset();
        InputHandler.GenerateInputList();
    }

    // Update is called once per frame
    void Update() {
        InputHandler.Inputs();
    }
    
    public void GenerateOffset() {
        int shift = (int) Random.Range(1, 26);
        Debug.Log("Shift Amount = " + shift);

        for (int i = 0; i < alphabet.Length; i++) {
            offset[i] = original[shift];
            shift++;

            if (shift >= 26) {
                shift = 0;
            }
        }
    }

    
}
    

