using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TimeScript : MonoBehaviour 
{
	private float time = 60;
	public GameObject gameOverText;
	public AudioClip endGame;
	private AudioSource audio_source;

		void Start () 
		{
			gameOverText.SetActive(false);
			GetComponent<Text>().text = ((int)time).ToString();
		}

		void Update ()
		{
			time -= Time.deltaTime;
			GetComponent<Text> ().text = ((int)time).ToString ();
			//Debug.Log(time);
			if (time < 0) 
			{
				//Debug.Log("StartCoroutine");
				StartCoroutine(GameOver());

				if (time < 0) time = 0;
					GetComponent<Text> ().text = ((int)time).ToString ();
					//Debug.Log("GetComponent");
					IEnumerator GameOver() 
					{
						//Debug.Log("IEnumerator");
						gameOverText.SetActive(true);
						//audio_source.Play();
						yield return new WaitForSeconds(2.0f);
						Application.LoadLevel ("title");
					}
			}	
		}
}