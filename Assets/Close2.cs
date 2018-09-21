using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
    public class Close2 : ButtonHelper
    {
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.CloseSettings2();
            RemoveListener();
        }
    }
}
