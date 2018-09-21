using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
    public class Pause : ButtonHelper
    {
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.Pause();



    }
        public override void OnDisable()
        {

        }
    }
}
