using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EasyMode : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] private TextMeshProUGUI available, unavailable;

    // Needed elements
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private char[] original = new char[26], offset = new char[26]; //, unusable = new char[26];
    private List<char> ListOfOriginalChars = new List<char>();
    private bool isLegit; 

    // Start is called before the first frame update
    void Start() {
        GenerateOriginalCharList();
        GenerateOffset();
        
        InputHandler.GenerateInputList();
    }

    // Update is called once per frame
    void Update() {
        isLegit = InputHandler.Inputs(ListOfOriginalChars);
        if(isLegit)
            Debug.Log(isLegit);
    }

    public void GenerateOriginalCharList() {
        original = (alphabet.ToLower()).ToCharArray();
        foreach (char ch in original) {
            ListOfOriginalChars.Add(ch);
        }
    }

    public void DisplayOptions() {
        DisplayAvailableOptions();
        DisplayUnavailableOptions();
    }
    
    public void DisplayAvailableOptions() {
        available.text = "";
        foreach (char ch in ListOfOriginalChars) {
            available.text += (ch + "  ");
        }
    }

    public void DisplayUnavailableOptions()
    {
        unavailable.text = "";
        foreach (var VARIABLE in COLLECTION)
        {
            
        }
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
    

