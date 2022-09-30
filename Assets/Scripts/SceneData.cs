using NaughtyAttributes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
    public class SceneData : MonoBehaviour
    {
        public Camera MainCamera;
        public EventSystem EventSystem;
        public EntityLink[] Entities;

        [Button]
        public void Grab()
        {
            Entities = GameObject.FindObjectsOfType<EntityLink>();
        }
    }
}