using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject copy;

	public List<Stats> lst = new List<Stats>(8);
	public int SelIdx; // selected index

	void Start()
	{
		Stats[] stats = FindObjectsOfType(typeof(Stats)) as Stats[];
		foreach (Stats stat in stats) 
		{
			lst.Add(stat);
		}
		lst.Sort(delegate(Stats x, Stats y)
		           {
			if (x.Initiative == y.Initiative) return 0;
			else if (x.Initiative < y.Initiative) return 1;
			else return -1;

		});

		SelIdx = 0;
		lst[SelIdx].transform.GetComponent<Renderer>().material.color = Color.red;

		StartCoroutine ("WaitAndChangeColor");
		StartCoroutine ("CopyRight");


	
	}

	void Update(){

	}



	IEnumerator WaitAndChangeColor() {
		while (true) 
		{
				yield return new WaitForSeconds (1);
				lst[SelIdx].transform.GetComponent<Renderer>().material.color = Color.white;
			SelIdx = (SelIdx + 1) % lst.Count;
			lst[SelIdx].transform.GetComponent<Renderer>().material.color = Color.red;


		}
	}

	IEnumerator CopyRight(){
		yield return new WaitForSeconds(3);
		copy.SetActive(true);
	}

	void OnMouseDown() 
	{

	}

	void turn(){

	}
}
