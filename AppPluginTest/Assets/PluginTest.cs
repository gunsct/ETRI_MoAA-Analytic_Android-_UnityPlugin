using UnityEngine;
using System.Collections;

public class PluginTest : MonoBehaviour {
	string messge = "init";

	void Awake(){
		ETRI_MoAA.getInstance.Create();
	}
	//// Use this for initialization
	void Start () {
		// 새로룬 오브젝트를 만들지 않고, com.unity3d.player.UnityPlayer의 
		// static 멤버에 접근하기 위해 AndroidJavaClass를 사용한다.
		// (사실 Android UnityPlayer가 자동으로 인스턴스를 생성해준다)
		// 그리고 static 필드인 currentActivity를 접근한다.
		// 그리고 이경우 AndroidJavaObject를 사용한다. 
		// 이유는 실제 필드 타입이 android.app.Activity이고
		// 이건 java.lang.Object를 상속받는다. 
		// 그리고, non-primitive 타입은 무조껀 AndroidJavaObject로 접근해야한다.
		// 예외 : strings.

		messge += "\n" + "Initialize success";

	}
	void OnGUI()
	{
		// 이렇게 접근하는 방법은, static이나 non-static 모두
		// 동일한 방법으로 접근 가능하다

		if (GUI.Button(new Rect(100, 200, 100, 50), "StaticInt"))
		{   
			ETRI_MoAA.getInstance.onAction ("GetStaticIntButtonTest", "GetStaticIntButtonClick", 3L);
		}

		if (GUI.Button(new Rect(100, 300, 100, 50), "Int"))
		{
			ETRI_MoAA.getInstance.onAction("GetIntButtonTest", "GetIntButtonClick",2L);
		}

		if (GUI.Button(new Rect(100, 400, 100, 50), "String"))
		{
			ETRI_MoAA.getInstance.onAction("GetStringButtonTest", "GetStringButtonClick",4L);
		}

		if (GUI.Button(new Rect(100, 500, 100, 50), "OnActionTest"))
		{
			ETRI_MoAA.getInstance.onAction("ButtonTest", "ButtonClick",5L);
			messge += "\n" + "onAction success";
		}

		if (GUI.Button(new Rect(100, 600, 100, 50), "SetAge&GenderTest"))
		{
			ETRI_MoAA.getInstance.setAge(35);
			ETRI_MoAA.getInstance.setGender("F");
			messge += "\n" + "setAge, setGender success";
		}

		if (GUI.Button(new Rect(100, 700, 100, 50), "LocationTest"))
		{
			ETRI_MoAA.getInstance.useLocationService();
			messge += "\n" + "useLocationService success";
		}

		GUI.Label(new Rect(Screen.width / 2 - 350, Screen.height / 2 - 150, 700, 300), messge);
	}
}