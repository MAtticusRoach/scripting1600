using UnityEngine;
using System.Collections;

public class ScopeandAccess : MonoBehaviour 
{
	public int alpha = 5;


	private int beta = 0;
	private int gamma = 5;



	private AnotherClass myOtherClass;


	void Start () 
	{
		alpha = 29;

		myOtherClass = new AnotherClass ();
		myOtherClass.MaterialMachine (alpha, myOtherClass.rocks);

	}

	void Example (int branch, int leaves) 
	{
		int answer;
		answer = branch * leaves * alpha;
		Debug.Log (answer);
	}



	void Update ()
	{
		Debug.Log ("Alpha is set to: " + alpha);
	}
}

