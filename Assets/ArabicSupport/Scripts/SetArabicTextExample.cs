using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using ArabicSupport;

public class SetArabicTextExample : MonoBehaviour {
	
	public string text;
	
	// Use this for initialization
	void Start () {	
		gameObject.GetComponent<Text>().text = ArabicFixer.Fix(text, false, false);
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
