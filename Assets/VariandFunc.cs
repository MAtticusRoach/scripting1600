using UnityEngine;
using System.Collections;

public class VariandFunc : MonoBehaviour 
{ 
	int myInt = 5;


	void Start ()

	{
		myInt = MulitplyByTwo(myInt);
		Debug.Log (myInt);
	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}

}

