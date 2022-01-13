/*******************************************************************************
 * File             : Tester.cs
 * Desc             : 
 * Author           : Toni Westerlund (toni.westerlund@lapinamk.fi)
 * Licence          : MIT
 * Version          : 
 * 
 *  Copyright (c) 2020 Toni Westerlund
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 *
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * 
 ******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField]
    private GameObject pointA;

    [SerializeField]
    private GameObject pointB;


    // Start is called before the first frame update
    void Start()
    {
        // Verrataan mitä eroa on käyttää set/get ominaisuutta ja set/get metodia
        Character setGetCharacter = new Character();
        setGetCharacter.CharacterName = "ToniW"; // SET
        Debug.Log("Tester - Start() -> myCharacter.CharacterName :" + setGetCharacter.CharacterName);
        setGetCharacter.SetCharacterName("ToniW"); // Set Method
        Debug.Log("Tester - Start() -> myCharacter.CharacterName :" + setGetCharacter.CharacterName);


        // Testataan mitä staattinen muuttuja tarkoittaa. Staattinen muuttuja on sama kaikille
        // luokan oliolle/instanseille
        Character heightCharacter1 = new Character();
        Character.height = 3;
        Character heightCharacter2 = new Character("TONIW");
        Character heightCharacter3 = new Character();
        Character heightCharacter4 = new Character();

        Debug.Log("Tester - Start() -> heightCharacter1 height :" + heightCharacter1.GetHeight());
        Debug.Log("Tester - Start() -> heightCharacter1 height :" + heightCharacter2.GetHeight());
        Debug.Log("Tester - Start() -> heightCharacter1 height :" + heightCharacter3.GetHeight());
        Debug.Log("Tester - Start() -> heightCharacter1 height :" + heightCharacter4.GetHeight());


        // Staattisen metodin käyttö, luokasta ei tarvitse luoda instassia/oliota
        string newName = Character.GenerateName();

        // Esimerkki Unityn Staattisesta metodista "Distance"
        float dist = Vector3.Distance(pointA.transform.position, pointB.transform.position);
        Debug.Log("Tester - Start() -> Distance : " + dist);

        // Late-Binding / Myöhäinen sidonta
        object lateCharacter;
        lateCharacter = new Character();
        Debug.Log("Tester - Start() -> lateCharacter : " + lateCharacter.GetType());
        ((Character)lateCharacter).Attack();


        // Esimerkki olio-ohjelmoinnin käytöstä
        Character weaponCharacter = new Character();
        weaponCharacter.Weapon = new Sword();
        weaponCharacter.Weapon.Hit();
        weaponCharacter.Weapon = new Spear();
        weaponCharacter.Weapon.Hit();


        Character genericCharacter;
        genericCharacter = new Priest();
        genericCharacter.Attack();





        // Luodaan olio/instanssi Character luokasta
        Character myCharacter = new Character(); // Rakentajan kutsu
        myCharacter.CharacterName = "ToniW";
        myCharacter.Attack();

        // Käytetään kuormitettua metodia
        myCharacter.MoveForward(2);
        myCharacter.MoveForward(2.0);
        myCharacter.MoveForward(2.0f);
        myCharacter.MoveForward("2.0");

         
        // näkyvyysmääreet
        // myCharacter.rivateTestInt = 0; //private ei näy kuin luokan sisällä
        // myCharacter.protectedTestInt = 0; // Protected näkyy myös perityissä luokissa
        myCharacter.publicTestInt = 0; // Public Näkyy myös luokan ulkopuolella


        Debug.Log("Tester - Start() -->   myCharacter.CharacterName  : " + myCharacter.CharacterName);

        // Luodaan olio/instanssi character luokasta
        Character mySecondCharacter = new Character("ToniW");



        Priest myPriest = new Priest();
        myPriest.CharacterName = "Kyosti";
        myPriest.Attack();
        Debug.Log("Tester - Start() -->   myPriest.CharacterName  : " + myPriest.CharacterName);

    }

}
