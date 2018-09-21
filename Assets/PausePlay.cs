using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
    public class PausePlay : ButtonHelper
    {
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);
            menuManager.ClosePause();


    }
        public override void OnDisable()
        {
        }
    }
}
