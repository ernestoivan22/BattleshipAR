using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
    public bool empezar = false;
    void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.red;
        
    }
    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = Color.white;
        if (empezar)
        {
            
            Application.LoadLevel(1);

        }
        else
        {

        }

    }
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKeyUp(KeyCode.Escape))
            {

                //quit application on return button

                Application.Quit();
                
                return;

            }
        }
    }
}
