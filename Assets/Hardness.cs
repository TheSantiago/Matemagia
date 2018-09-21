using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MenuBarouch;

public class Hardness : MonoBehaviour {

    public Text Hard;
    public int hardness;

    public void OnClicked()
    {
            if (Hard.text == "FÁCIL")
            {
                Hard.text = "NORMAL";
                hardness = 0;
            }
            else if (Hard.text == "NORMAL")
            {
                Hard.text = "DIFÍCIL";
                hardness = 1;
            }
            else if (Hard.text == "DIFÍCIL")
            {
                Hard.text = "EXTREMO";
                hardness = 2;
            }
            else if (Hard.text == "EXTREMO")
            {
                Hard.text = "FÁCIL";
                hardness = 3;
            }
            else if (Hard.text == "SALTADAS")
            {
                Hard.text = "EN ORDEN";
                hardness = 4;
            }
            else if (Hard.text == "EN ORDEN")
            {
                Hard.text = "SALTADAS";
                hardness = 5;
            }

    }
}
