using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findChildres : MonoBehaviour
{

    private Transform meeple;
    public GameObject grandChild;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject getResaultsChilds(int child)
    {
        //Assigns the transform of the first child of the Game Object this script is attached to.
        //meeple = this.gameObject.transform.GetChild(0);

        //Assigns the first child of the first child of the Game Object this script is attached to.
      
        return grandChild;
    }
}
