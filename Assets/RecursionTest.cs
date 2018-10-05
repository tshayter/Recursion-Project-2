using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //CountTo(5);
        RecursiveCountTo(5);

	}

    public void CountTo (int number){ // A normal way to do things

        int counter = 1;

        while (counter <= number){

            Debug.Log(counter);
            counter++;

        }
    }

    public void RecursiveCountTo(int number, int counter = 1){ // default values can be set and don't need to be called (you can override them though)

        Debug.Log(counter);

        if (counter < number){

            RecursiveCountTo(number, counter +1);

        }

        //Debug.Log(counter);

    }

    public int ToPower(int number, int power){

        if (power <= 0) {

            return 1;

        } else {

            return number * ToPower(number, power - 1);


        }

        //return power <= 0 ? 1 : number * ToPower(number, power - 1);

    }
}
