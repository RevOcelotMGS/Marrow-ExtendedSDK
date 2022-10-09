using System.Runtime.InteropServices;
namespace Assets.Marrow_ExtendedSDK.StubClasses {
	public abstract class Agent {

        public virtual void CollectObservations(VectorSensor sensor)
		{
		}

        public virtual void Heuristic([In] ActionBuffers actionsOut)
		{
		}

        public virtual void Initialize()
		{
		}

        public virtual void OnActionReceived(ActionBuffers actionBuffers)
		{
		}

        public virtual void OnEpisodeBegin() {
        }
    }
}
