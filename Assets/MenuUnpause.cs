using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppAdvisory.MathGame
{
    public class MenuUnpause : ButtonHelper
    {
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.ClosePause();
            menuManager.GoToMenu();


        }
        public override void OnDisable()
        {
        }
    }
}
