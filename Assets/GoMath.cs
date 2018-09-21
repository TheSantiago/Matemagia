using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AppAdvisory.MathGame
{
    public class GoMath : ButtonHelper
    {
        public Text Hard;
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.GoMathMagic();
            Hard.text = "FÁCIL";
            RemoveListener();
        }
    }
}