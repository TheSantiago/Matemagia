using UnityEngine;
using System.Collections;
#if APPADVISORY_LEADERBOARD
using AppAdvisory.social;
#endif

namespace AppAdvisory.MathGame
{
	public class ButtonLeaderboard : ButtonHelper 
	{
		override public void OnClicked()
		{
			menuManager.MainMenu();
		}
	}
}