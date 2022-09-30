using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;
using LeopotamGroup.Globals;

namespace Game
{
    public class Game : MonoBehaviour
    {
        private EcsSystems _systems = default;
        private EcsWorld _world = default;
        public SceneData SceneData = default;
        public StaticData StaticData = default;

        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);


            #if UNITY_EDITOR
            Leopotam.Ecs.UnityIntegration.EcsWorldObserver.Create(_world);
            Leopotam.Ecs.UnityIntegration.EcsSystemsObserver.Create(_systems);
            #endif
            _systems
            .Add(new InitSystem())
            
            .Inject(SceneData)
            .Inject(StaticData)
            .Inject(_world)

            .Init();
        }

        private void Update()
        {
            _systems.Run();
        }

        private void OnDestroy()
        {
            _systems.Destroy();
            _world.Destroy();
        }
    }
}