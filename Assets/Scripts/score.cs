using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text changeText;
    public GameObject Change;

    // Update is called once per frame
    void Update()
    {
        changeText.text = "";
        Change.GetComponent<Text>().text = "2";
    }


}
