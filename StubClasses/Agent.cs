using System.Runtime.InteropServices;
namespace Assets.Marrow_ExtendedSDK.StubClasses {
	public abstract class Agent {

		public void CollectObservations(VectorSensor sensor)
		{
		}

		public void Heuristic([In] ActionBuffers actionsOut)
		{
		}

		public void Initialize()
		{
		}

		public void OnActionReceived(ActionBuffers actionBuffers)
		{
		}

        public void OnEpisodeBegin() {
        }
    }
}
