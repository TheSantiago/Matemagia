using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
namespace AppAdvisory.MathGame
{
    public class SendItUp : ButtonHelper
    {
        override public void OnClicked()
        {
            print("OnClicked : " + gameObject.name);

            if (gameObject.name == "One")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 1;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Two")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 2;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Three")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 3;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Four")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 4;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Five")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 5;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Six")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 6;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Seven")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 7;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Eight")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 8;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else if (gameObject.name == "Nine")
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 9;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }
            else
            {
                FindObjectOfType<MenuBarouch.MenuManager>().TheDigit = 0;
                FindObjectOfType<MenuBarouch.MenuManager>().GoToGame2();
            }

            RemoveListener();
        }
    }
}
