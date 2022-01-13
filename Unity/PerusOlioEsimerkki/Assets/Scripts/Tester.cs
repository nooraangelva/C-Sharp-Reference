using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    float circleArea = BasicMath.GetCircleArea(10f); 
    float tringleArea = BasicMath.GetTringleArea(12f,3);
    bool boolean = BasicMath.GetTrueOrFalse(3);
    string time = BasicMath.GetTime();
    string day = BasicMath.GetDay(2);
    List<int> fibonachi = BasicMath.GetFibo(3);
    int count = BasicMath.GetLotto();
     
    foreach (int val in fibonachi)
    {
        Debug.Log("Tester - Fibo"+val);
    }

    Debug.Log("Tester - circleArea"+circleArea);
    Debug.Log("Tester - tringleArea"+tringleArea);
    Debug.Log("Tester - Boolean"+boolean);
    Debug.Log("Tester - time"+time);
    Debug.Log("Tester - day"+day);


    Person myPerson = new Person("NooraA", 1999);
    Debug.Log("Person"+myPerson.PersonName+" age: "+myPerson.Age);

    Piano myPiano = new Piano();
    myPiano.Manufactor = "Trek";
    myPiano.NumberOfKeys = 33;

    Debug.Log("Piano- "+myPiano.Manufactor + "keys: "+myPiano.NumberOfKeys);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
