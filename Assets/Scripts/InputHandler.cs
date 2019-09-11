using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private static List<KeyCode> keyCodes = new List<KeyCode>();
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

    public static bool CheckInputs(KeyCode kc, List<char> list, char ch) {
        if (keyCodes.Contains(kc)) {
            Debug.Log("Press => " + kc);
            keyCodes.Remove(kc);
            
            int index = list.IndexOf(ch);
            list.Remove(ch);
            list.Insert(index, '*');
            
            return true;
        }
        else {
            Debug.Log("ERROR -> " + kc);
            return false;
        }
    }
    
    public static bool Inputs(List<char> list) {
        if (Input.GetKeyDown(KeyCode.A)) {
           return CheckInputs(KeyCode.A, list, 'a');
        }
        else if (Input.GetKeyDown(KeyCode.B)) {
            return CheckInputs(KeyCode.B, list, 'b');
        }
        else if (Input.GetKeyDown(KeyCode.C)) {
            return CheckInputs(KeyCode.C, list, 'c');
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            return CheckInputs(KeyCode.D, list, 'd');
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            return CheckInputs(KeyCode.E, list, 'e');
        }  
        else if (Input.GetKeyDown(KeyCode.F)){
            return CheckInputs(KeyCode.F, list, 'f');
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            return CheckInputs(KeyCode.G, list, 'g');
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            return CheckInputs(KeyCode.H, list, 'h');
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            return CheckInputs(KeyCode.I, list, 'i');
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            return CheckInputs(KeyCode.J, list, 'j');
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            return CheckInputs(KeyCode.K, list, 'k');
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            return CheckInputs(KeyCode.L, list, 'l');
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            return CheckInputs(KeyCode.M, list, 'm');
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            return CheckInputs(KeyCode.N, list, 'n');
        }
        else if (Input.GetKeyDown(KeyCode.O)) {
            return CheckInputs(KeyCode.O, list, 'o');
        }
        else if (Input.GetKeyDown(KeyCode.P)) {
            return CheckInputs(KeyCode.P, list, 'p');
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            return CheckInputs(KeyCode.Q, list, 'q');
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            return CheckInputs(KeyCode.R, list, 'r');
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            return CheckInputs(KeyCode.S, list, 's');
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            return CheckInputs(KeyCode.T, list, 't');
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            return CheckInputs(KeyCode.U, list, 'u');
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            return CheckInputs(KeyCode.V, list, 'v');
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            return CheckInputs(KeyCode.W, list, 'w');
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            return CheckInputs(KeyCode.X, list, 'x');
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            return CheckInputs(KeyCode.Y, list, 'y');
        }
        else if (Input.GetKeyDown(KeyCode.Z)) {
            return CheckInputs(KeyCode.Z, list, 'z');
        }
        else {
            return false;
        }
    }
}
