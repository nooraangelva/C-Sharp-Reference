/*******************************************************************************
 * File             : Character.cs
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

public class Character
{

    /// <summary>
    /// Staattinen muuttuja, Staattinen muuttuja on "yhteinen" kaikille luokan oliolle/instanseille
    /// </summary>
    public static float height = 2f;


    // Nämä muuttujat on luotu näkymääreiden testaamista varten
    private int privateTestInt;
    protected int protectedTestInt;
    public int publicTestInt;


    /// <summary>
    /// Weapon (Luokan Jäsenmuuttuja)
    /// </summary>
    private Weapon weapon;

    /// <summary>
    /// Set/Get 
    /// </summary>
    public Weapon Weapon
    {
        get
        {
            return this.weapon;
        }
        set
        {
            this.weapon = value;
        }

    }


    /// <summary>
    /// Character Name (Luokan Jäsenmuuttuja)
    /// </summary>
    private string characterName;


    /// <summary>
    /// Set / Get 
    /// </summary>
    public string CharacterName
    {
        get
        {
            return this.characterName;
        }
        set
        {
            this.characterName = value;
        }

    }

    /// <summary>
    /// Set metodi, tämä metodi asettaa characterName luokan jäsenmuuttujan arvon (vrt. Set/Get)
    /// </summary>
    /// <param name="name"></param>
    public void SetCharacterName(string name)
    {
        this.characterName = name;
    }

    /// <summary>
    /// Get Metodi tämä metodi palauttaa characterName luokan jäsenmuuttujan arvon (vrt. Set/Get)
    /// </summary>
    /// <returns></returns>
    public string GetCharacterName()
    {
        return this.characterName;
    }

    /// <summary>
    /// Character Rakentaja/Muodostin/Constructor
    /// </summary>
    public Character()
    {
        Debug.Log("Character - Character() -> Constructor");
    }

    /// <summary>
    /// Character Rakentaja/Muodostin/Constructor
    /// Kaksi rakentajaa (kuormittaminen)
    /// </summary>
    /// <param name="characterName"></param>
    public Character(string characterName)
    {
        Debug.Log("Character - Character() -> Constructor");

        this.characterName = characterName;
    }

    /// <summary>
    /// virtual kertoo että tämä metodi voidaan ylikirjoittaa
    /// </summary>
    public virtual void Attack()
    {
        Debug.Log("Character - Attack()");
    }

    /// <summary>
    /// Useita MoveForward metodeja, jotka poikkeavat parametreiltänsä, puhutaan
    /// metodien kuormittamisesta
    /// </summary>

    public void MoveForward()
    {
        Debug.Log("Character - MoveForward()");

        // näkyvyysmääreet
        privateTestInt = 0; // private ei näy kuin luokan sisällä
        protectedTestInt = 0; // Protected näkyy myös perityissä luokissa
        publicTestInt = 0; // Public Näkyy myös luokan ulkopuolella


        // TODO : Move Character By Default Speed
    }

   public void MoveForward(float speed)
    {
        Debug.Log("Character - MoveForward()");
        // TODO : Move Character By custom Speed (Method Parameter)
    }

    public void MoveForward(int speed)
    {
        Debug.Log("Character - MoveForward()");
        // TODO : Move Character By custom Speed (Method Parameter)
    }

    public void MoveForward(double speed)
    {
        Debug.Log("Character - MoveForward()");
        // TODO : Move Character By custom Speed (Method Parameter)
    }

    public void MoveForward(string speed)
    {
        Debug.Log("Character - MoveForward()");
        // TODO : Need convert string to float
        // TODO : Move Character By custom Speed (Method Parameter)
    }


    /// <summary>
    /// Palauttaa staattisen muuttujan arvon
    /// </summary>
    /// <returns></returns>
    public float GetHeight()
    {
        return height;
    }

    /// <summary>
    /// Staattinen metodi, voidaan kutsua ilman että luokasta on luotu instanssia/oliota
    /// </summary>
    /// <returns></returns>
    public static string GenerateName()
    {
        string name = "sadasdasdas"; // FIXME: Add random mecanism
        return name;
    }

}
