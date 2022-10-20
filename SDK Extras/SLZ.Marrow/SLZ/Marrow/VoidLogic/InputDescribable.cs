using System.Collections.Generic;

namespace SLZ.Marrow.VoidLogic
{
	public interface InputDescribable
	{
		IReadOnlyList<InputDescription> DescribeInputs();
	}
}
