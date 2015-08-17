using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour {

	Image img;
	public Sprite cicadaSprite;
	public Sprite a_tree;
	public Sprite b_homeless;
	public Sprite c_hill;
	public Sprite d_hill;

	void Start () {
		img = gameObject.GetComponent<Image> ();
	}
	
	void Update () {
	
	}

	public void toCicada() {
		printShit ();
		img.sprite = cicadaSprite;
	}

	public void printShit() {
		print ("print shit");
	}

	public void toNextBg() {

	}
}
