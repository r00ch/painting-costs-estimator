namespace Estimator.Library
{
	public struct Dimension
	{
		public int Length { get; set; }
		public int Height { get; set; }

		public int SurfaceSize
		{
			get { return Length * Height; }
		}

	}
}