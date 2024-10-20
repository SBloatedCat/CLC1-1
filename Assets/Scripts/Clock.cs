using UnityEngine;
using System;
public class Clock: MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    float hoursToDegrees = -30f, minutesToDefrees=-6f, secondsToDegrees=-6f;
    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, hoursToDegrees * (float)time.TotalHours, 0f );
        minutesPivot.localRotation = Quaternion.Euler(0f, minutesToDefrees * (float)time.TotalMinutes, 0f);
        secondsPivot.localRotation = Quaternion.Euler(0f, secondsToDegrees * (float)time.TotalSeconds, 0f);
    }
}