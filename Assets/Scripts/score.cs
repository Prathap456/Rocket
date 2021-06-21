using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField]
    public int fuel;
    [SerializeField]
    public Text fuelText;
    // Update is called once per frame

    private void Start()
    {
        fuelText.text = "Fuel :" + fuel;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Invoke("fuelConsume", Time.deltaTime);
            fuelText.text = "Fuel :" + fuel;
        }

        
        
    }

   public void fuelConsume()
    {
        if(fuel != 0)
        {
            fuel--;
        }
        else
        {
            fuelText.text = "Fuel Empty";
        }
        
    }

}
