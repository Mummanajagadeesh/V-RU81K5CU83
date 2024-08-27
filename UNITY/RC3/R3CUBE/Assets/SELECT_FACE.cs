using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SELECT_FACE : MonoBehaviour
{
    private CUBE_STATE cubeState;
    private READ_CUBE readCube;
    private int layerMask = 1 << 8;

    
    // Start is called before the first frame update
    void Start()
    {
        readCube = FindObjectOfType<READ_CUBE>();
        cubeState = FindObjectOfType<CUBE_STATE>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !CUBE_STATE.autoRotating)
        {
            // read the current state of the cube            
            readCube.ReadState();

            // raycast from the mouse towards the cube to see if a face is hit  
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f, layerMask))
            {
                GameObject face = hit.collider.gameObject;
                // Make a list of all the sides (lists of face GameObjects)
                List<List<GameObject>> cubeSides = new List<List<GameObject>>()
                {
                    cubeState.up,
                    cubeState.down,
                    cubeState.left,
                    cubeState.right,
                    cubeState.front,
                    cubeState.back
                };
                // If the face hit exists within a side
                foreach (List<GameObject> cubeSide in cubeSides)
                {
                    if (cubeSide.Contains(face))
                    {
                        //Pick it up
                        cubeState.PickUp(cubeSide);
                        //start the side rotation logic
                        cubeSide[4].transform.parent.GetComponent<PIVOT_ROTATION>().Rotate(cubeSide);
                    }
                }
            }
        }
    }
}
