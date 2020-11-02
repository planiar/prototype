using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class exit : MonoBehaviour
{
  async void OnTriggerEnter2D(Collider2D col)
   	{
   		if (col.gameObject.tag == "Player")//ゴールのオブジェクトに接触したらクリアシーンへの切り替え
   	  {
              Debug.Log("touch!");
              GetComponent<AudioSource>().Play(); 
              await Task.Delay (1200);
              SceneManager.LoadScene("TopDownDemo2");
		  }
    }
}