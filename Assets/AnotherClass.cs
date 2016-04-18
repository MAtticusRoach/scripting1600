using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
{
	public int rocks;
	public int sticks;



	private int glove;
	private int shoes;


	public void MaterialMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Material total: 10" + answer);
	}



	private void ClothingSort (int a, int b) 
	{
		int answer;
		answer = a + b;
		Debug.Log ("Clothing Supplies total: " + answer);
	}
}