using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour 
{

	public int Initiative;
	bool isTurn = false;

	void Start(){

		Initiative = Random.Range(1,20);
	}


}
