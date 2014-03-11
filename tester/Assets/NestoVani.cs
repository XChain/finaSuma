﻿using UnityEngine;
using System.Collections;
using System;

public class NestoVani : MonoBehaviour {

	private static DateTime selectedDate = DateTime.Now;
	class DateCallback : AndroidJavaProxy
	{
		public DateCallback() : base("android.app.DatePickerDialog$OnDateSetListener") { }
		void onDateSet(AndroidJavaObject view, int year, int monthOfYear, int dayOfMonth)
		{
			selectedDate = new DateTime(year, monthOfYear+1, dayOfMonth);
		}
	}
	void OnGUI ()
	{
		if (GUI.Button(new Rect (15, 15, 450, 75), string.Format("{0:yyyy-MM-dd}", selectedDate)))
		{
			var activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			activity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
			                                                       {
				new AndroidJavaObject("android.app.DatePickerDialog", activity, new DateCallback(), selectedDate.Year, selectedDate.Month-1, selectedDate.Day).Call("show");
			}));
		}
	}
}
