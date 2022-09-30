using Leopotam.Ecs;

namespace Game
{
    public class InitSystem : IEcsInitSystem
    {
        private readonly SceneData _sceneData = default;
        private readonly EcsWorld _world = default;
    
        public void Init()
        {
            foreach(var i in _sceneData.Entities)
            {
                i.Init(_world);
            }
        }
    }
}