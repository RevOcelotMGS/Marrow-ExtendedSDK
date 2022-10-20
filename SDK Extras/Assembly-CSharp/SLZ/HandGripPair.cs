using SLZ.Interaction;

namespace SLZ
{
	public struct HandGripPair
	{
		public Hand hand;

		public Grip grip;

		public HandGripPair(Hand h, Grip g)
		{
			this.grip = default(Grip);
			this.hand = default(Hand);
		}

		public void Clear()
		{
		}
	}
}
