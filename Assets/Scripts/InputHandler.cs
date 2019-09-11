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

    public static bool CheckInputs(KeyCode kc) {
        if (keyCodes.Contains(kc)) {
            Debug.Log("Press => " + kc);
            keyCodes.Remove(kc);
            return true;
        }
        else {
            Debug.Log("ERROR -> " + kc);
            return false;
        }
        return false;
    }
    
    public static bool Inputs() {
        if (Input.GetKeyDown(KeyCode.A)) {
           return CheckInputs(KeyCode.A);
        }
        else if (Input.GetKeyDown(KeyCode.B)) {
            return CheckInputs(KeyCode.B);
        }
        else if (Input.GetKeyDown(KeyCode.C)) {
            return CheckInputs(KeyCode.C);
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            return CheckInputs(KeyCode.D);
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            return CheckInputs(KeyCode.E);
        }  
        else if (Input.GetKeyDown(KeyCode.F)){
            return CheckInputs(KeyCode.F);
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            return CheckInputs(KeyCode.G);
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            return CheckInputs(KeyCode.H);
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            return CheckInputs(KeyCode.I);
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            return CheckInputs(KeyCode.J);
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            return CheckInputs(KeyCode.K);
        }
        else if (Input.GetKeyDown(KeyCode.L)) {
            return CheckInputs(KeyCode.L);
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            return CheckInputs(KeyCode.M);
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            return CheckInputs(KeyCode.N);
        }
        else if (Input.GetKeyDown(KeyCode.O)) {
            return CheckInputs(KeyCode.O);
        }
        else if (Input.GetKeyDown(KeyCode.P)) {
            return CheckInputs(KeyCode.P);
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            return CheckInputs(KeyCode.Q);
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            return CheckInputs(KeyCode.R);
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            return CheckInputs(KeyCode.S);
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            return CheckInputs(KeyCode.T);
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            return CheckInputs(KeyCode.U);
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            return CheckInputs(KeyCode.V);
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            return CheckInputs(KeyCode.W);
        }
        else if (Input.GetKeyDown(KeyCode.X)) {
            return CheckInputs(KeyCode.X);
        }
        else if (Input.GetKeyDown(KeyCode.Y)) {
            return CheckInputs(KeyCode.Y);
        }
        else if (Input.GetKeyDown(KeyCode.Z)) {
            return CheckInputs(KeyCode.Z);
        }
        else {
            return false;
        }
    }
}
