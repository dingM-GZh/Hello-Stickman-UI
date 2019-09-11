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

    public static void CheckInputs(KeyCode kc) {
        if (keyCodes.Contains(kc)) {
            Debug.Log("You have pressed KeyCode = " + kc);
            keyCodes.Remove(kc);
        }
        else {
            Debug.Log("Cannot be found - " + kc);
        }
        
    }
    
    public static void Inputs() {
        if (Input.GetKeyDown(KeyCode.A)) {
            CheckInputs(KeyCode.A);
        }
        else if (Input.GetKeyDown(KeyCode.B)) {
            CheckInputs(KeyCode.B);
        }
        else if (Input.GetKeyDown(KeyCode.C)) {
            CheckInputs(KeyCode.C);
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            CheckInputs(KeyCode.D);
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            CheckInputs(KeyCode.E);
        }  
        else if (Input.GetKeyDown(KeyCode.F)){
            CheckInputs(KeyCode.F);
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            CheckInputs(KeyCode.G);
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            CheckInputs(KeyCode.H);
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            CheckInputs(KeyCode.I);
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            CheckInputs(KeyCode.J);
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            CheckInputs(KeyCode.K);
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            CheckInputs(KeyCode.L);
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            CheckInputs(KeyCode.M);
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            CheckInputs(KeyCode.N);
        }
        else if (Input.GetKeyDown(KeyCode.O)) {
            CheckInputs(KeyCode.O);
        }
        else if (Input.GetKeyDown(KeyCode.P)) {
            CheckInputs(KeyCode.P);
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            CheckInputs(KeyCode.Q);
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            CheckInputs(KeyCode.R);
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            CheckInputs(KeyCode.S);
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            CheckInputs(KeyCode.T);
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            CheckInputs(KeyCode.U);
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            CheckInputs(KeyCode.V);
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            CheckInputs(KeyCode.W);
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            CheckInputs(KeyCode.X);
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            CheckInputs(KeyCode.Y);
        }
        else if (Input.GetKeyDown(KeyCode.Z)) {
            CheckInputs(KeyCode.Z);
        }
    }
}
