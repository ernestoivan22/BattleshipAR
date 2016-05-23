using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public GameObject plane;
    public int width = 10;
    public int height = 10;
    private GameObject[,] grid;

    void Awake()
    {
        grid = new GameObject[width, height];
        for (int x =0; x < width; x++)
        {
            for(int z = 0; z < height; z++)
            {
                GameObject gridPlane = (GameObject)Instantiate(plane);
                gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + gridPlane.transform.localScale.x*10*x,
                    gridPlane.transform.position.y, gridPlane.transform.position.z - plane.transform.localScale.z*10*z);
                grid[x, z] = gridPlane;
            }
        }
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(10,10,150,100),"Delete grid [3,3]"))
        {
            Destroy(grid[3, 3]);
        }
    }
}
