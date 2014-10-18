using UnityEngine;
using System.Collections;
using System;

//Ядро - управляет всеми прочими классами проекта, экземпляр ядра обрабатывается unity
public class Core : MonoBehaviour {

    private static ResourcesManager resourcesManager; //менеджер ресурсов

    public static ResourcesManager getResourcesManager()
    {
        return resourcesManager;
    }

    //Инициализация игры
	void Start () {
        resourcesManager = new ResourcesManager();
        resourcesManager.initialize();
        test();
	}

    //Временно вынес тесты в отдельный метод
    void test() {
    }
	
    //Тут будет обновление глобального игрового состояния
	void Update () {
    
	
	}

    void OnGUI() {
        GUI.Box(new Rect(0, 0, 100, 100), "");
    }
}
