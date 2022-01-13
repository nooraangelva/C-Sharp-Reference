/*******************************************************************************
 * File             : Priest.cs
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

public class Priest : Character
{
    /// <summary>
    /// Ylikirjoitetaan Character Luokan Attack Metodi
    /// </summary>
    public override void Attack()
    {
        Debug.Log("Priest - Attack() --> Cast Shield");

        // näkyvyysmääreet
        // privateTestInt = 0; private ei näy kuin luokan sisällä
        protectedTestInt = 0; // Protected näkyy myös perityissä luokissa
        publicTestInt = 0; // Public Näkyy myös luokan ulkopuolella

        // Base sanalla voidaan kutsua myös perus luokan Attack metodia (Character luokan Attack metodi)
        base.Attack();
    }
}
