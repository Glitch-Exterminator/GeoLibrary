namespace GeoLibrary
{
	public class Segment
	{
		public Vector Begin { get; set; }
		public Vector End { get; set; }
		public double GetLength() => Geometry.GetLength(this);

		public Segment() {}
		public Segment(Vector begin, Vector end) { Begin = begin; End = end; }

		public bool Contains(Vector vector) => Geometry.IsVectorInSegment(vector, this);
	}
}