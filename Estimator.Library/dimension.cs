namespace Estimator.Library
{
	public struct Dimension
	{
		public int Length { get; set; }
		public int Height { get; set; }
		private int _surfaceSiize;

		public int SurfaceSize
		{
			get { return Length * Height; }
		}

	}
}