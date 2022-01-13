using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person 
{
 private string personName;
 private int yearOfBirth;
 private int age;
public int Age
{
    get
    {
        return this.age;
    }
}
public string PersonName
{
    get
    {
        return this.personName;
    }
}
 public Person(string name, int yearBirth)
 {
     this.personName = name;
     this.yearOfBirth = yearBirth;
     this.age = System.DateTime.Now.Year - yearOfBirth;
     
 }   
}
