using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    private string u = "username";
    private string p = "password";

    public GameObject UserName;
    public GameObject PassWord;
    InputField usrnm;
    InputField psswrd;


    void Start () {
        usrnm = UserName.GetComponent<InputField>();
        psswrd = PassWord.GetComponent<InputField>();
    }

	void Update () {
      
	}

    void OnGui()
    {
       
    }

    
    }
