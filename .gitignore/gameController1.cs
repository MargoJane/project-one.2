using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController1 : MonoBehaviour {
	public static int bronzeOre;
	public static int silverOre;
	public static int goldOre;
	int timeToMine;
	int miningSpeed;

	Vector3 cubePosition;
	GameObject currentCube;
	float xPosition;
	float yPosition;
	public GameObject Cube;


	// Use this for initialization
	void Start () {
		bronzeOre= 0;
		silverOre= 0;
		goldOre = 0;
		miningSpeed= 3;

		timeToMine= miningSpeed;

		xPosition = -5f;
		yPosition = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		//Mine for Bronze

		if (Time.time > timeToMine) {

			if (bronzeOre == 2 && silverOre ==2){
				goldOre += 1;

				xPosition += Random.Range(-15,15);
				yPosition += Random.Range(-7,7);

				cubePosition = new Vector3 (xPosition, yPosition, 0f);
				currentCube= Instantiate(Cube, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.yellow;
			}

			else if (bronzeOre < 4) {
				bronzeOre += 1;

				cubePosition = new Vector3 (xPosition, yPosition, 0f);
				currentCube= Instantiate(Cube, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.red;

				xPosition += Random.Range(-15, 15);
				yPosition += Random.Range(-7,7);


			}
			//Mine for silver after bronze is gone
			else if (bronzeOre>=4) {
				silverOre += 1;

				xPosition += Random.Range(-15,15);
				yPosition += Random.Range(-7,7);

				cubePosition = new Vector3 (xPosition, yPosition, 0f);
				currentCube= Instantiate(Cube, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.gray;
		
			}
				

			timeToMine += miningSpeed;

		}
	}
}