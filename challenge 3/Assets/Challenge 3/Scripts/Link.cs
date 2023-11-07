using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenLinkJSPlugin()
	{
		#if !UNITY_EDITOR
		openWindow("https://elitesssstar.github.io/Unit3/");
		//Application.OpenUrl("https://elitesssstar.github.io/Unit3/");

		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}