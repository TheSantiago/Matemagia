using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppAdvisory.MathGame
{
    public class MainSettings : ButtonHelper
    {

        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.OpenSettings2();
            RemoveListener();
        }
    }
}

