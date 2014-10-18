using UnityEngine;
using System.Collections;
using System;

public class Core : MonoBehaviour {

    private ResourcesManager resourcesManager;

	void Start () {
        resourcesManager = new ResourcesManager();
        resourcesManager.initialize();
        test();
	}

    void test() {
    }
	
	void Update () {
    
	
	}

    void OnGUI() {
        
    }
}
