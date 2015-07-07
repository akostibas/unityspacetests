using UnityEngine;
using System.Collections;

public class CreateStars : MonoBehaviour
{

	[SerializeField]
	private GameObject starPrefab;
	[SerializeField]
	private GameObject starField;
	[SerializeField]
	private int numberOfStars = 100;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Making " + numberOfStars + " stars.");
		Debug.Log ("position: " + starField.transform.localPosition);
		Debug.Log ("scale: " + starField.transform.localScale);
		for (int i = 0; i <= numberOfStars; i++) {
			float locationX = starField.transform.localPosition.x + ((Random.value - 0.5f) * starField.transform.localScale.x);
			float locationY = starField.transform.localPosition.y + ((Random.value - 0.5f) * starField.transform.localScale.y);
			float locationZ = starField.transform.localPosition.z + ((Random.value - 0.5f) * starField.transform.localScale.z);

			Vector3 position = new Vector3 (locationX, locationY, locationZ);
			var newStar = Instantiate (starPrefab,
				              position,
				              Quaternion.identity) as GameObject;
			newStar.transform.parent = starField.transform;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
