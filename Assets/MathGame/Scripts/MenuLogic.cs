using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace AppAdvisory.MathGame
{
	public class MenuLogic : MonoBehaviour
	{

		public GameObject FirstTimeMenu;

		public GameObject GameOverMenu;

		public Transform Title;


		public Text M;

		public Text A;

		public Text T;

		public Text H;




		bool firstTime;

		void Awake()
		{
			firstTime = true;
		}

		public void OnEnable()
		{

			foreach (Transform t in Title)
			{
				t.localScale = Vector3.one;

			}

			FirstTimeMenu.SetActive (firstTime);
			GameOverMenu.SetActive (!firstTime);

			if (!firstTime) 
			{
				M.text = "M";
				A.text = "A";
				T.text = "T";
				H.text = "E";

			}

			firstTime = false;
		}

		public void OnDisable()
		{
			foreach (Transform t in Title) 
			{
				t.localScale = Vector3.one;
			}
		}
	}
}