using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreenHandler : MonoBehaviour
{
    private static List<char> inputs;

    [SerializeField] private TextMeshProUGUI usedInputs, numberOfInputs;
    // Start is called before the first frame update
    void Start()
    {
        GetInputList();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayInputs();
    }

    public static void GetInputList() {
        inputs = InputHandler.GetUnavailableCharList();
    }

    public void DisplayInputs() {
        usedInputs.text = "";
        foreach (var ch in inputs) {
            usedInputs.text += (ch + "  ");
        }

        numberOfInputs.text = "Number of Inputs \n" + inputs.Count;
    }
}
