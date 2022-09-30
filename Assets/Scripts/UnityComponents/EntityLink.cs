using Leopotam.Ecs;
using UnityEngine;

namespace Game
{
    public class EntityLink : MonoBehaviour
    {
        public EcsEntity Entity;
        public EcsWorld World;

        public void Init(EcsWorld world)
        {
            World = world;
            Entity = World.NewEntity();
            ref var t = ref Entity.Get<TransformComponent>();
            t.Transform = transform;
            OnInit();
        }

        protected virtual void OnInit()
        {

        }
    }
}