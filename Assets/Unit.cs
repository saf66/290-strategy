using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	
	private bool genGui = false;
	private bool baseUnit = true;
	private bool buildUnit = false;
	private bool mineUnit = false;
	private bool weldUnit = false;
	private bool baseGui = false;
	private bool buildGui = false;
	private bool mineGui = false;
	private bool weldGui = false;
	private bool build = false;
	private bool mine = false;
	private bool weld = false;
	private bool score = false;
	public int buildSkill = 5;
	public int mineSkill = 5;
	public int weldSkill = 5;
	public Texture builder;
	public Texture miner;
	public Texture welder;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(buildSkill >= 10 && buildSkill >= mineSkill && buildSkill >= weldSkill)
			transform.renderer.material.mainTexture = builder;
		else if(mineSkill >= 10 && mineSkill >= buildSkill && mineSkill >= weldSkill)
			transform.renderer.material.mainTexture = miner;
		else if(weldSkill >= 10 && weldSkill >= buildSkill && weldSkill >= mineSkill)
			transform.renderer.material.mainTexture = welder;
	
	}
	
	void OnMouseDown(){
		genGui = true;
		score = true;
		if(baseUnit)
			baseGui = true;
		if(buildUnit)
			buildGui = true;
		if(mineUnit)
			mineGui = true;
		if(weldUnit)
			weldGui = true;
	}
		
	
	void OnGUI () {
		if(score)
			GUI.Label (new Rect (Screen.width*0.9f,Screen.height*.02f, 100, 80), "Build Skill: " + buildSkill 
				+ "\nMine Skill: " + mineSkill + "\nWeld Skill: " + weldSkill);
		if(genGui){
			string[] genOptions = {"Build","Mine","Weld"};
			int toolbar = GUI.Toolbar (new Rect(Screen.width*0.40f,Screen.height*0.9f,250,50),3,genOptions);
			if(toolbar == 0){
				build = true;
				genGui = false;
			}
			if(toolbar == 1){
				mine = true;
				genGui = false;
			}
			if(toolbar == 2){
				weld = true;
				genGui = false;
			}
		}
		if(build){
			string[] buildOptions = {"Build 1","Build 2","Build 3"};
			int toolbar = GUI.Toolbar (new Rect(Screen.width*0.40f,Screen.height*0.9f,250,50),3,buildOptions);
			if(toolbar == 0){
				buildSkill++;
				build = false;
				score= false;
			}
			if(toolbar == 1){
				buildSkill++;
				build = false;
				score= false;
			}
			if(toolbar == 2){
				buildSkill++;
				build = false;
				score= false;
			}
		}
		if(mine){
			string[] mineOptions = {"Mine 1","Mine 2","Mine 3"};
			int toolbar = GUI.Toolbar (new Rect(Screen.width*0.40f,Screen.height*0.9f,250,50),3,mineOptions);
			if(toolbar == 0){
				mineSkill++;
				mine = false;
				score= false;
			}
			if(toolbar == 1){
				mineSkill++;
				mine = false;
				score= false;
			}
			if(toolbar == 2){
				mineSkill++;
				mine = false;
				score= false;
			}
		}
		if(weld){
			string[] weldOptions = {"Weld 1","Weld 2","Weld 3"};
			int toolbar = GUI.Toolbar (new Rect(Screen.width*0.40f,Screen.height*0.9f,250,50),3,weldOptions);
			if(toolbar == 0){
				weldSkill++;
				weld = false;
				score= false;
			}
			if(toolbar == 1){
				weldSkill++;
				weld = false;
				score= false;
			}
			if(toolbar == 2){
				weldSkill++;
				weld = false;
				score= false;
			}
		}
		
	}
				
}
