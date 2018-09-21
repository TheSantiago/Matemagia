using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MenuBarouch
{

	public class MenuManager : MonoBehaviour 
	{
		public GameObject MENU;

		public GameObject GAME;

		public GameObject SETTING;
        public GameObject SETTING2;
        public GameObject Main;
        public GameObject OVER;
        public GameObject Title;
        public GameObject Title2;
        public GameObject PauseMenu;

        public GameObject Mathy;
        public GameObject Tably;

        public GameObject Ordained;

        public bool Sophie = true;

        public Image BACKGROUND_BACK;

		public Color NORMAL_COLOR;

        public bool Mode = true;

        public Text hardness;
        public int TheDigit = 0;

		void Awake()
		{
			MENU.SetActive (true);
			GAME.SetActive (false);
			SETTING.SetActive (false);
		}

        public void MainMenu()
        {
            MENU.SetActive(true);
            float time = 0.2f;
            GoOut(OVER, time, 0);
            GoIn(Main, time, time);
        }

        //open the game
        public void GoToGame()
		{
            if(hardness.text!="EN ORDEN")
            {
                float time = 0.2f;
                GoOut(MENU, time, 0);
                GoIn(GAME, time, time);
            }
            else
            {
                float time = 0.2f;
                GoOut(Main, time, 0);
                GoIn(Ordained, time, time);
            }
		}
        public void GoToGame2()
        {
                float time = 0.2f;
                GoOut(MENU, time, 0);
                GoIn(GAME, time, time);
                Ordained.SetActive(false);
        }

        //open the menu
        public void GoToMenu()
		{
			float time = 0.2f;
			GoOut (GAME,time,0);
			GoIn (MENU, time, time);
            GoIn(OVER, time, time);
		}

		//open the setting menu
		public void OpenSettings()
		{
			float time = 0.2f;
			GoOut (MENU,time,0);
			GoIn (SETTING, time, time);
		}
        public void OpenSettings2()
        {
            float time = 0.2f;
            GoOut(Main, time, 0);
            GoOut(Title, time, 0);
            GoOut(Title2, time, 0);
            GoIn(SETTING2, time, time);
        }

        //close the setting menu
        public void CloseSettings()
		{
			float time = 0.2f;
			GoOut (SETTING,time,0);
			GoIn (MENU, time, time);
		}
        public void CloseSettings2()
        {
            float time = 0.2f;
            GoOut(SETTING2, time, 0);
            GoIn(Title, time, time);
            GoIn(Title2, time, time);
            GoIn(Main, time, time);
        }

        public void Pause()
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        public void ClosePause()
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        public void GoTable()
        {
            Tably.SetActive(true);
            Mathy.SetActive(false);
            Sophie = false;
        }
        
        public void GoMathMagic()
        {
            Tably.SetActive(false);
            Mathy.SetActive(true);
            Sophie = true;
        }

        void Update()
		{
			BACKGROUND_BACK.color = Color.Lerp(BACKGROUND_BACK.color, NORMAL_COLOR,Time.time);
		}

		//animation scale from 1 to 0
		public void GoOut(GameObject obj, float time, float delay)
		{
			obj.transform.localScale = Vector3.one;
			StartCoroutine (GoInOrOutCorout (obj, 0, time, delay, () => {
				obj.transform.localScale = Vector3.zero;
				obj.SetActive(false);
			}));

		}

		//animation scale from 0 to 1
		public void GoIn(GameObject obj, float time, float delay){
			obj.transform.localScale = Vector3.zero;
			StartCoroutine (GoInOrOutCorout (obj, 1, time, delay, () => {
				obj.transform.localScale = Vector3.one;
				obj.SetActive(true);
			}));

		}

		//do the animation scale
		IEnumerator GoInOrOutCorout(GameObject obj, float scale, float time, float delay, Action callback)
		{
			obj.SetActive(true);

			yield return new WaitForSeconds (delay);

			var originalScale = obj.transform.localScale;
			var targetScale = Vector3.one * scale;
			var originalTime = time;

			while (time > 0.0f)
			{
				time -= Time.deltaTime;
				obj.transform.localScale = Vector3.Lerp(targetScale, originalScale, time / originalTime);
				yield return 0;
			}

			if (callback != null)
				callback ();
		}
	}
}
