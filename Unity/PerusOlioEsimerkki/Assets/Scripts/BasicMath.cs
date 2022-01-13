using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BasicMath 
{
    public static float GetCircleArea(float radius)
    {
        float circleArea = 0f;
        //area = Pir^2
        circleArea = Mathf.PI * Mathf.Pow(radius, 2);
        return circleArea;
    }

    public static float GetTringleArea(float a, float h)
    {
        float tringleArea = 0f;
        tringleArea = (a * h) / 2f;
        return tringleArea;
    }

    public static bool GetTrueOrFalse(int number)
    {
        bool boolean = false;
        if(number % 2 == 0)
        {
            boolean = true;
        }
        return boolean;
    }
    
    public static string GetTime()
    {
        string time = "";
        time = System.DateTime.Now.ToString();
        return time;
    }

    public static string GetDay(int dayNumber)
    {
        string day = "";
        switch(dayNumber)
        {
            case 0:
            {
                day = "Monday";
                break;
            }
            case 1:
            {
                day = "Tuesday";
                break;
            }
            case 2:
            {
                day = "Wednesday";
                break;
            }
            case 3:
            {
                day = "Thursday";
                break;
            }
            case 4:
            {
                day = "Friday";
                break;
            }
            case 5:
            {
                day = "Saturday";
                break;
            }
            case 6:
            {
                day = "Sunday";
                break;
            }
            default:
            {
                break;  
            }

        }
        return day;
    }

    public static List<int> GetFibo(int length)
    {
        List<int> list = new List<int>();
        int a = 0;
        int b = 1;
        int c = 0;

        for(int i = 2; i < length; i++)
        {
            c = a + b;
            list.Add(c);
            a = b;
            b = c;
        }
        
        return list;
    }

    public static int GetLotto()
    {
        int count = 0;
        for(int i = 0; i< 100; i++)
        {
            int number = UnityEngine.Random.Range(0,100);
            if(number < 50)
            {
                count++;
            }
        }
        
        return count;
    }
}
