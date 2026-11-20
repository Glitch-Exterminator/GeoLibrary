namespace GeoLibrary
{
	internal class Vector
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double GetLength() => Geometry.GetLength(this);

		public Vector() {}
		public Vector(double x, double y) { X = x; Y = y; }

		public Vector Add(Vector vector1, Vector vector2) => Geometry.Add(vector1, vector2);
		public bool Belongs(Segment segment) => Geometry.IsVectorInSegment(this, segment);
	}
}