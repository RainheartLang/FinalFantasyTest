using UnityEngine;
using System.Collections;
using System;

//Ядро - управляет всеми прочими классами проекта, экземпляр ядра обрабатывается unity
public class Core : MonoBehaviour {

    private static ResourcesManager resourcesManager; //менеджер ресурсов
    private static GuiControllerBase guiController;

    public static ResourcesManager getResourcesManager()
    {
        return resourcesManager;
    }


    //Инициализация игры
	void Start () {
        resourcesManager = new ResourcesManager();
        resourcesManager.initialize();
        guiController = new MainScreenGUIController();
        guiController.initialize();
        test();
	}

    //Временно вынес тесты в отдельный метод
    void test() {
    }
	
    //Тут будет обновление глобального игрового состояния
	void Update () {
	}

    void OnGUI() {
        guiController.update();
        GUI.Box(new Rect(0, 0, 100, 100), "" + Input.mousePosition.x + " " + Input.mousePosition.y);
    }
}
