using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ResourceContainer {

    private Type resourceType;
    private SortedDictionary<string, object> resources;
	
    public ResourceContainer(Type type)
    {
        this.resourceType = type;
        this.resources = new SortedDictionary<string, object>();
    }

    public Type getResourceType()
    {
        return this.resourceType;
    }

    public object find(string path)
    {
        object result;
        if (resources.TryGetValue(path, out result))
        {
            return result;
        }
        return null;
    }

    public void add(string key, object value)
    {
        if (value.GetType() != this.resourceType)
        {
            Debug.Log("Ошибка: попытка записать контейнер ресурсов объект неверного типа. "
                + "Тип контейнера: " + this.resourceType + ". Тип объекта: " + value.GetType() + ".");
        }
        else
        {
            resources.Add(key, value);
        }
    }
}
