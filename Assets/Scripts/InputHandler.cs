using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private static List<KeyCode> keyCodes = new List<KeyCode>();
    private static List<char> availableChars = new List<char>(), 
                              unavailableChars = new List<char>(), offset = new List<char>();
    private static char[] alphabet;
    

    public static void Initialisation() {
        GenerateInputList();
        GenerateCharList();
    }

    public static void GenerateInputList() {
        keyCodes.Add(KeyCode.A);
        keyCodes.Add(KeyCode.B);
        keyCodes.Add(KeyCode.C);
        keyCodes.Add(KeyCode.D);
        keyCodes.Add(KeyCode.E);
        keyCodes.Add(KeyCode.F);
        keyCodes.Add(KeyCode.G);
        keyCodes.Add(KeyCode.H);
        keyCodes.Add(KeyCode.I);
        keyCodes.Add(KeyCode.J);
        keyCodes.Add(KeyCode.K);
        keyCodes.Add(KeyCode.L);
        keyCodes.Add(KeyCode.M);
        keyCodes.Add(KeyCode.N);
        keyCodes.Add(KeyCode.O);
        keyCodes.Add(KeyCode.P);
        keyCodes.Add(KeyCode.Q);
        keyCodes.Add(KeyCode.R);
        keyCodes.Add(KeyCode.S);
        keyCodes.Add(KeyCode.T);
        keyCodes.Add(KeyCode.U);
        keyCodes.Add(KeyCode.V);
        keyCodes.Add(KeyCode.W);
        keyCodes.Add(KeyCode.X);
        keyCodes.Add(KeyCode.Y);
        keyCodes.Add(KeyCode.Z);
    }

    public static void GetOffset(char[] offset) {
        int i = 1;
        foreach (var ch in offset) {
            InputHandler.offset.Add(ch);
            Debug.Log(i + "  " + ch);
            i++;
        }
    }
    
    public static List<char> GenerateCharList() {
        alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
        foreach (var ch in alphabet) {
            availableChars.Add(ch);
        }
        return availableChars;
    }

    public static List<char> GetUnavailableCharList() {
        return unavailableChars;
    }

    public static bool CheckInputs(KeyCode kc, char ch) {
        if (keyCodes.Contains(kc)) {
            Debug.Log("Press => " + kc);
            keyCodes.Remove(kc);
            
            int index = availableChars.IndexOf(ch);
            Debug.Log("Index " + index);
            
            availableChars.Insert(index, '*');
            availableChars.Remove(ch);
            
            char temp = offset.ElementAt(index);
            HelloWorldHandler.GetDeletedOffset(temp);
            
           //offset.RemoveAt(index);

            unavailableChars.Add(ch);
            return true;
        }
        else {
            Debug.Log("ERROR -> " + kc);
            return false;
        }
    }
    
    public static void Inputs() {
        if (Input.GetKeyDown(KeyCode.A)) {
           CheckInputs(KeyCode.A,'a');
        }
        else if (Input.GetKeyDown(KeyCode.B)) {
            CheckInputs(KeyCode.B, 'b');
        }
        else if (Input.GetKeyDown(KeyCode.C)) {
            CheckInputs(KeyCode.C, 'c');
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            CheckInputs(KeyCode.D, 'd');
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            CheckInputs(KeyCode.E, 'e');
        }  
        else if (Input.GetKeyDown(KeyCode.F)){
            CheckInputs(KeyCode.F, 'f');
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            CheckInputs(KeyCode.G, 'g');
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            CheckInputs(KeyCode.H, 'h');
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            CheckInputs(KeyCode.I, 'i');
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            CheckInputs(KeyCode.J, 'j');
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            CheckInputs(KeyCode.K, 'k');
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            CheckInputs(KeyCode.L, 'l');
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            CheckInputs(KeyCode.M, 'm');
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            CheckInputs(KeyCode.N, 'n');
        }
        else if (Input.GetKeyDown(KeyCode.O)) {
            CheckInputs(KeyCode.O, 'o');
        }
        else if (Input.GetKeyDown(KeyCode.P)) {
            CheckInputs(KeyCode.P, 'p');
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            CheckInputs(KeyCode.Q, 'q');
        }
        else if (Input.GetKeyDown(KeyCode.R)) { 
            CheckInputs(KeyCode.R, 'r');
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            CheckInputs(KeyCode.S, 's');
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            CheckInputs(KeyCode.T, 't');
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            CheckInputs(KeyCode.U, 'u');
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            CheckInputs(KeyCode.V, 'v');
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            CheckInputs(KeyCode.W, 'w');
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            CheckInputs(KeyCode.X, 'x');
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            CheckInputs(KeyCode.Y, 'y');
        }
        else if (Input.GetKeyDown(KeyCode.Z)) {
            CheckInputs(KeyCode.Z, 'z');
        }
        else {
            
        }
    }
}
