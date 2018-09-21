using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
    public class XpManager
    {
        public static void XP(int Score)
        {
            int finalScore = Score + PlayerPrefs.GetInt("XP");
            PlayerPrefs.SetInt("XP", finalScore);
            PlayerPrefs.Save();
        }
    }
}