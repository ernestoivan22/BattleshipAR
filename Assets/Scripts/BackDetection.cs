using UnityEngine;
using System.Collections;

public class BackDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKeyUp(KeyCode.Escape))
            {

                //quit application on return button

                //Application.Quit();
                Application.LoadLevel(0);
                return;

            }
        }
    }
}
