using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreenHandler : MonoBehaviour
{
    private static List<char> inputs;

    [SerializeField] private static TextMeshProUGUI usedInputs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GetInputList(List<char> list)
    {
        
    }

    public void DisplayInputs() {
        usedInputs.text = "";
        foreach (var ch in inputs) {
            usedInputs.text += (ch + "  ");
        }
    }
}
