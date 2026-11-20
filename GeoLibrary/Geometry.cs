namespace GeoLibrary
{
	public class Geometry
	{
		public static double GetLength(Vector vector) =>
			Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2));

		public static double GetLength(Segment segment) =>
			Math.Sqrt(Math.Pow(segment.End.X - segment.Begin.X, 2) + Math.Pow(segment.End.Y - segment.Begin.Y, 2));

		public static Vector Add(Vector vector1, Vector vector2) =>
			new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y);

		public static bool IsVectorInSegment(Vector vector, Segment segment) =>
			Math.Abs(GetLength(new Segment(segment.Begin, vector)) + GetLength(new Segment(vector, segment.End)) - GetLength(segment)) < 1e-9;
	}
}