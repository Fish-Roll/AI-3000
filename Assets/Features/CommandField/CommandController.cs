using Features.AI;

namespace Features.CommandField
{
    public class CommandController
    {
        private AIManager _aiManager;
        
        public void Init(AIManager aiManager)
        {
            _aiManager = aiManager;
        }
        
        public void HandleCommand(string command)
        {
            switch (command)
            {
                case "Follow":
                    _aiManager.Follow();
                    break;
                case "Here":
                    _aiManager.Here();
                    break;
                case "Stop":
                    _aiManager.Stop();
                    break;
                case "Down":
                    _aiManager.Down();
                    break;
                case "Push":
                    _aiManager.Push();
                    break;
                default:
                    return;
            }
            //Debug.Log(Enum.GetName(typeof(Commands.Commands), Commands.Commands.Follow));
        }
    }
}